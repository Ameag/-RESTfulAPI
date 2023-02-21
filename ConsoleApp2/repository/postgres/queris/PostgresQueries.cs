using It_PlanetaApi.repository.postgres.queris;
using It_PlanetaApi.repository.postgres.queris.account;
using repository.It_PlanetaApi.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris
{
    public class Queries
    {
        public IQueriesAccount Account;

        public Queries()
        {
            Account = new PostgresQueriesAccount();
        }
    }


}
