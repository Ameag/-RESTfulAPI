using It_PlanetaApi.handler.account;
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
        public Handler(Service service) 
        {
            Account = new Account(service);
        }
    }
}
