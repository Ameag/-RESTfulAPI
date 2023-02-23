using It_PlanetaApi.models.account;
using It_PlanetaApi.repository;
using It_PlanetaApi.repository.postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service.account
{
    public class Account : ServiceResponsibility, IAccount
    {
        public Account(Repository repository) : base(repository) {}
        public PostgresAccount Registration(RegistrationInput props)
        {
            // валидация 
            return _repository.Account.Create(
                props.firstName, 
                props.lastName, 
                props.email,
                props.password);
        }
    }
}
