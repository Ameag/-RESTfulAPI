using It_PlanetaApi.models.location;
using It_PlanetaApi.repository;
using It_PlanetaApi.repository.postgres.queris.location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service.location
{
    internal class Location : ServiceResponsibility, ILocation
    {
        public Location(Repository repository) : base(repository)
        {
        }

        public PostgresLocation Create(CreateLocationInput props)
        {
            if(props.latitude== null||props.latitude<-90||props.latitude>90)
            {
                ThrowInvalidRequestField("invalid latitude: {0}", props.latitude);
            }
            if(props.longitude == null|| props.longitude <-180||props.longitude>180)
            {
                ThrowInvalidRequestField("invalid longitude: {0}", props.longitude);
            }

            return _repository.Location.Create((double)props.latitude, (double)props.longitude);
        }

        public PostgresLocation GetInfoLocation(string param)
        {
            if(param == null||int.Parse(param)<=0)
            {
                ThrowInvalidRequestField("invalid pointId: {0}", param);
            }
            return _repository.Location.GetInfoAccount(param);
        }
    }
}
