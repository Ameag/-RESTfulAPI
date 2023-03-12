using It_PlanetaApi.models.account;
using It_PlanetaApi.models.animal;
using It_PlanetaApi.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.handler.animal
{
    public class Animal : HendlerRensponsibility, IAnimal
    {
        public Animal(Service service) : base(service)
        {
        }

        public void Create(RequestContext context) 
        {
            var input = context.GetBody<CreateAnimalInput>();
            var animal = _service.Animal.Create(input);
            var output = new CreateAnimalOutput()
            {
                Id = animal.Id,
                Weight= animal.Weight,
                Length = animal.Length,
                Height= animal.Height,
                Gender= animal.Gender,
                LifeStatus= animal.LifeStatus,
                ChippingDateTime= animal.ChippingDateTime,
                ChipperId= animal.ChipperId,
                ChippingLocationId= animal.ChippingLocationId,
                DeathDateTime= animal.DeathDateTime

            };
            context.SendCreated(output);
        }
    }
}
