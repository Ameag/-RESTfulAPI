using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris.location
{
    public class PostgresLocation
    {
        [PostgresName("id")]
        public long Id { get; set; }

        [PostgresName("latitude")]
        public double Latitude { get; set; }
        [PostgresName("longitude")]
        public double Longitude { get; set; }

    }
}
