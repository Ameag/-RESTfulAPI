using It_PlanetaApi.repository.postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.It_PlanetaApi.Account
{
    public interface IAccount
    {
        public PostgresAccount Create(string firstName, string lastName, string email, string password);
        public PostgresAccount Get(string email, string password);
        

        
    }
}
