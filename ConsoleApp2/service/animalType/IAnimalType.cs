using It_PlanetaApi.models.animalType;
using It_PlanetaApi.models.location;
using It_PlanetaApi.repository.postgres.queris.animalType;
using It_PlanetaApi.repository.postgres.queris.location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service.animalType
{
    public interface IAnimalType
    {
        public PostgresAnimalType Create(CreateAnimalTypeInput props);
    }
}
