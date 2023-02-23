using It_PlanetaApi.config;
using It_PlanetaApi.handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.server
{
    public class Server
    {
        private readonly string SERVER_URL = "http://localhost:8080/";
        private readonly string SERVER_START_MESSAGE = "Server is started";
        private readonly HttpListener _listener;
        private readonly Router _router;
        public Server(Config config, Router router) 
        {
            var port = config.GetPort();
            _listener = new HttpListener(); 
            _router= router;
            _listener.Prefixes.Add(this.SERVER_URL + port);
        }
        public void Run()
        {
            _listener.Start();
            Console.WriteLine(this.SERVER_START_MESSAGE);
            while(true) 
            {
                var requestContext = new RequestContext(_listener);
                _router.HandleRequest(requestContext);
            }
        }

    }
}
