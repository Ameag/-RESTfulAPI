using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris.AnimalVisitedLocation
{
    public class AnimalVisitedLocation
    {
        [PostgresName("id")]
        public long? Id { get; set; }
        [PostgresName("date")]
        public string? Date { get; set; }
        [PostgresName("animal")]
        public long? Animal { get; set; }
        [PostgresName("location")]
        public long? Location { get; set; }

    }
}
