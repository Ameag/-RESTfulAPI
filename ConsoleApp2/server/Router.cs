using It_PlanetaApi.handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.server
{
    public class Router
    {
        private Handler handler;

        public Router(Handler handler)
        {
            
        }

        public void HandleRequest(RequestContext context)
        {
            // определить в какую функцию отправить запрос на обработку 
        }
    }
}
