using It_PlanetaApi.handler.account;
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
        public Handler(Service service) 
        {
            Account = new Account(service);
            Location = new Location(service);
        }

        public Router GetRouter() 
        { 
            var router = new Router();
            router.POST("/registration", Account.Registration);
            router.POST("/locations", Location.Create);

            return router;
        }
    }
}
