using It_PlanetaApi.models.location;
using It_PlanetaApi.repository.postgres.queris.location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service.location
{
    public interface ILocation
    {
        public PostgresLocation Create (CreateLocationInput props);
        public PostgresLocation GetInfoLocation(string param);
    }
}
