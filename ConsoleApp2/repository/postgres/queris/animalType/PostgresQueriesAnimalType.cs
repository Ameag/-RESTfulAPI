using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris.animalType
{
    internal class PostgresQueriesAnimalType : IQueriesAnimalType
    {
        public string Create()
        {
            return "INSERT INTO \"AnimalType\"(value) VALUES ($1) RETURNING*";
        }
    }
}
