using It_PlanetaApi.handler.account;
using It_PlanetaApi.handler.animalType;
using It_PlanetaApi.handler.location;
using It_PlanetaApi.server;
using It_PlanetaApi.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.handler
{
    public class Handler
    {
        public readonly IAccount Account;
        public readonly Ilocation Location;
        public readonly IAnimalType AnimalType;
        public Handler(Service service) 
        {
            Account = new Account(service);
            Location = new Location(service);
            AnimalType= new AnimalType(service);
        }

        public Router GetRouter() 
        { 
            var router = new Router();
            router.POST("/registration", Account.Registration);
            router.POST("/locations", Location.Create);
            router.POST("/animals/types", AnimalType.Create);
            router.GET("/accounts/{accountId}", Account.GetInfo);
            router.GET("/locations/{pointId}",Location.GetInfoLocation);
            router.GET("/animals/types/{typeId}",AnimalType.GetInfoType);

            return router;
        }
    }
}
