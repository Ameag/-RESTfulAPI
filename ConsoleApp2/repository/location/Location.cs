using It_PlanetaApi.repository.postgres.queris;
using It_PlanetaApi.repository.postgres.queris.location;
using repository.postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.location
{
    public class Location : RepositoryResponsibility, ILocation
    {
        public Location(PostgresDatabase database, Queries queries) : base(database, queries)
        {
        }

        public PostgresLocation Create(double latitude, double longitude)
        {
            var query = Queries.Location.Create();
            return GetResultObject<PostgresLocation>(query, latitude, longitude);
        }
    }
}
