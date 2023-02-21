using It_PlanetaApi.repository;
using It_PlanetaApi.repository.postgres;
using It_PlanetaApi.repository.postgres.queris;
using Npgsql;
using repository.postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.It_PlanetaApi.Account
{
    public class Account : RepositoryResponsibility, IAccount
    {
        public Account(PostgresDatabase database, Queries queries): base(database, queries) 
        {
            
        }

        public PostgresAccount Create(string firstName, string lastName, string email, string password)
        {
            Queries.Account.Create();
            var query = Queries.Account.Create();
                return GetResultObject<PostgresAccount>(query,firstName,lastName,email,password);
        }

        public PostgresAccount Get(string email, string password)
        {
            var query = Queries.Account.Get();
            return GetResultObject<PostgresAccount>(query,email, password);
        }
    }
}
