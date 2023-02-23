using It_PlanetaApi.config;
using It_PlanetaApi.handler;
using It_PlanetaApi.server.router;
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
        private readonly string SERVER_URL = "http://localhost:";
        private readonly string SERVER_START_MESSAGE = "Server is started";
        private readonly string PRINT_REQUEST_TEMPLATE = "[{0:G}]\t[{1}]\t[{2}]";
        private readonly HttpListener _listener;
        private readonly Router _router;
        public Server(Config config, Router router) 
        {
            var port = config.GetPort();
            _listener = new HttpListener(); 
            _router= router;
            _listener.Prefixes.Add(this.SERVER_URL + port+"/");
        }
        public void Run()
        {
            _listener.Start();
            Console.WriteLine(this.SERVER_START_MESSAGE);
            while(true) 
            {
                var requestContext = new RequestContext(_listener);
                PrintRequestLog(requestContext);
                _router.HandleRequest(requestContext);
            }
        }

        private void PrintRequestLog(RequestContext requestContext)
        {
            var currentTime =  DateTime.Now;
            var method = requestContext.GetMethod();
            var endPoint = requestContext.GetEndPoint();
            Console.WriteLine(PRINT_REQUEST_TEMPLATE
                ,currentTime.ToShortDateString() + ":"+ currentTime.ToShortTimeString()
                ,method
                ,endPoint);
        }
    }
}
