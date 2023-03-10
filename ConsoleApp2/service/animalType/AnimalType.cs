using It_PlanetaApi.models.animalType;
using It_PlanetaApi.models.location;
using It_PlanetaApi.repository;
using It_PlanetaApi.repository.postgres.queris.animalType;
using It_PlanetaApi.repository.postgres.queris.location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service.animalType
{
    internal class AnimalType : ServiceResponsibility, IAnimalType
    {
        public AnimalType(Repository repository) : base(repository)
        {
        }

        public PostgresAnimalType Create(CreateAnimalTypeInput props)
        {
            if(props.value == null||props.value.Trim() == "")
            {
                ThrowInvalidRequestField("invalid type: {0}", props.value);
            }
            return _repository.AnimalType.Create(props.value);
        }

        public PostgresAnimalType GetInfoType(string param)
        {
            if(param==null||int.Parse(param) <= 0)
            {
                ThrowInvalidRequestField("invalid type: {0}", param);
            }
            return _repository.AnimalType.GetInfoType(param);
        }
    }
    
}
