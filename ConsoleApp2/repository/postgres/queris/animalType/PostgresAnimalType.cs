using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris.animalType
{
    public class PostgresAnimalType
    {
        [PostgresName("id")]
        public long Id { get; set; }

        [PostgresName("value")]
        public string Value { get; set; }

    }
}
