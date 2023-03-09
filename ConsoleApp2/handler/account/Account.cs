using It_PlanetaApi.models.account;
using It_PlanetaApi.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.handler.account
{
    public class Account : HendlerRensponsibility, IAccount
    {
        public Account(Service service) : base(service)
        {
        }

        public void GetInfo(RequestContext context)
        {
            var param = context.GetParam("accountId");
            var account = _service.Account.GetInfoAccount(param);
            var output = new RegistrationOutput
            {
                id = account.Id,
                firstName = account.FirstName,
                lastName = account.LastName,
                email = account.Email
            };
            context.SendCreated(output);

        }

        public void Registration(RequestContext context)
        {
            var input = context.GetBody<RegistrationInput>();
            var account = _service.Account.Registration(input);
            var output = new RegistrationOutput
            {
                id = account.Id,
                firstName= account.FirstName,
                lastName= account.LastName,
                email= account.Email
            };
            context.SendCreated(output);
        }
    }
}
