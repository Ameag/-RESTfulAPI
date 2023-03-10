using It_PlanetaApi.models.animalType;
using It_PlanetaApi.models.location;
using It_PlanetaApi.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.handler.animalType
{
    public class AnimalType : HendlerRensponsibility, IAnimalType
    {
        public AnimalType(Service service) : base(service)
        {
        }

        public void GetInfoType(RequestContext context)
        {
            var param = context.GetParam("typeId");
            var animalType = _service.AnimalType.GetInfoType(param);
            var output = new CreateAnimalTypeOutput()
            {
                id = animalType.Id,
                value = animalType.Value
            };
            context.SendCreated(output);

        }

        public void Create(RequestContext context) 
        {
            var input = context.GetBody<CreateAnimalTypeInput>();
            var animalType = _service.AnimalType.Create(input);
            var output = new CreateAnimalTypeOutput()
            {
                id = animalType.Id,
                value = animalType.Value
            };
            context.SendCreated(output);
        }
    }
}
