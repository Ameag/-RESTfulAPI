using It_PlanetaApi.repository.postgres.queris;
using It_PlanetaApi.repository.postgres.queris.animalType;
using It_PlanetaApi.repository.postgres.queris.location;
using Newtonsoft.Json.Linq;
using repository.postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.animalType
{
    internal class AnimalType : RepositoryResponsibility, IAnimalType
    {
        public AnimalType(PostgresDatabase database, Queries queries) : base(database, queries)
        {
        }

        public PostgresAnimalType Create(string value)
        {
            var query = Queries.animalType.Create();
            return GetResultObject<PostgresAnimalType>(query,value);
        }
    }
}
