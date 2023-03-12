using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris.animalToType
{
    public class PostgresAnimalToType
    {
        [PostgresName("animal")]
        public long? AnimalTipes { get; set; }
        [PostgresName("type")]
        public long? Type { get; set; }
    }
}
