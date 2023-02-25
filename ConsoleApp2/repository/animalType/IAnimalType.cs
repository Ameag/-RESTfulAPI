using It_PlanetaApi.repository.postgres.queris.animalType;
using It_PlanetaApi.repository.postgres.queris.location;
using Npgsql.PostgresTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.animalType
{
    public interface IAnimalType
    {
        public PostgresAnimalType Create(string value);
    }
}
