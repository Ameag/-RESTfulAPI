using It_PlanetaApi.repository.postgres.queris.location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.location
{
    public interface ILocation
    {
        public PostgresLocation Create(double latitude,double longitude);
    }
}
