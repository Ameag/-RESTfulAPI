using It_PlanetaApi.repository;
using It_PlanetaApi.service.account;
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

        public Service(Repository repository) 
        {
            Account = new Account(repository);
        }
    }
}
