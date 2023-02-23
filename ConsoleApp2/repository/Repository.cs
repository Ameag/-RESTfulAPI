
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using It_PlanetaApi.repository.postgres.queris;
using repository.It_PlanetaApi.Account;
using repository.postgres;

namespace It_PlanetaApi.repository
{
    public class Repository
    {
        public IAccount Account;

        public Repository(PostgresDatabase database) 
        {
            var queries = new Queries();
            Account = new Account(database,queries);
        }
    }
}
