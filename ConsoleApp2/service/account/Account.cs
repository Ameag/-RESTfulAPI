using It_PlanetaApi.Exceptions;
using It_PlanetaApi.models.account;
using It_PlanetaApi.repository;
using It_PlanetaApi.repository.account;
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

            if(props.firstName== null||props.firstName.Trim()=="") 
            {
                ThrowInvalidRequestField("invalid firts name:{0}", props.firstName);
            }
            if (props.lastName == null || props.lastName.Trim() == "")
            {
                ThrowInvalidRequestField("invalid firts name {0}", props.lastName);
            }
            if (props.email == null || props.email.Trim() == "")
            {
                ThrowInvalidRequestField("invalid email{0}", props.email);
            }
            if (props.password == null || props.password.Trim() == "")
            {
                ThrowInvalidRequestField("invalid password{0}", props.password);
            }


            return _repository.Account.Create(
                props.firstName, 
                props.lastName, 
                props.email,
                props.password);
        }

        public PostgresAccount GetInfoAccount(string param)
        {
            if(param == null|| int.Parse(param)<=0)
            {
                ThrowInvalidRequestField("invalid param:{0}", param);
            }
            return _repository.Account.GetInfo(param);
        }

        
    }
}
