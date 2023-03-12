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

        public bool EqualsEndPoint(string currentEndPoint, RequestContext context)
        {
            string[] splitCurrentEndPoint = currentEndPoint.Split('/');
            string[] splitEndPoint = EndPoint.Split('/');
            for (int x = 0; x < splitCurrentEndPoint.Length; x++)
            {
                if(splitEndPoint[x].IndexOf('{')==-1)
                {
                    if (splitCurrentEndPoint[x] != splitEndPoint[x])
                    {
                        return false;
                    }
                    continue;
                }
                context.LoadParam(splitEndPoint[x].Replace("{", "").Replace("}", ""), splitCurrentEndPoint[x]);

            }
            return true;


        }


    }
}