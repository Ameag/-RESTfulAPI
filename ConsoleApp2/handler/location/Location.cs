using It_PlanetaApi.models.location;
using It_PlanetaApi.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.handler.location
{
    public class Location : HendlerRensponsibility, Ilocation
    {
        public Location(Service service) : base(service)
        {

        }
        public void GetInfoLocation(RequestContext context)
        {
            var param = context.GetParam("pointId");
            var location = _service.Location.GetInfoLocation(param);
            var output = new CreateLocationOutput()
            {
                id = location.Id,
                latitude = location.Latitude,
                longitude = location.Longitude,
            };
            context.SendCreated(output);
        }
        public void Create(RequestContext context)
        {
            var input = context.GetBody<CreateLocationInput>();
            var location = _service.Location.Create(input);
            var output = new CreateLocationOutput()
            {
                id = location.Id,
                latitude = location.Latitude,
                longitude = location.Longitude,
            };
            context.SendCreated(output);
        }
    }
}
