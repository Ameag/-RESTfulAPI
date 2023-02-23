using It_PlanetaApi.handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.server.router
{
    public class RouterPoint
    {
        public string EndPoint;
        public HttpMethod Method;
        public Action<RequestContext> Handler;
    }
}
