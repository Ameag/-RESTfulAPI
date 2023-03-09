using It_PlanetaApi.models.account;
using It_PlanetaApi.repository.account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service.account
{
    public interface IAccount
    {
        public PostgresAccount Registration(RegistrationInput props);
        public PostgresAccount GetInfoAccount(string param);
    }
}
