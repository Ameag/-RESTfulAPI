using It_PlanetaApi.repository;
using It_PlanetaApi.service.account;
using It_PlanetaApi.service.location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service
{
    public class Service
    {
        public IAccount Account;
        public ILocation Location;

        public Service(Repository repository) 
        {
            Account = new Account(repository);
            Location= new Location(repository);
        }
    }
}
