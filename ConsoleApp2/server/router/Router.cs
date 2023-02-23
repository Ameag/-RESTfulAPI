using It_PlanetaApi.Exceptions;
using It_PlanetaApi.handler;
using It_PlanetaApi.server.router;

namespace It_PlanetaApi.server
{
    public class Router
    {
        private readonly List<RouterPoint> _routerPoints;

        public Router()
        {
            _routerPoints = new List<RouterPoint>();
        }

        public void POST(string endPoint, Action<RequestContext> handler)
        {
            var routerPoint = new RouterPoint()
            {
                Method = HttpMethod.Post,
                EndPoint = endPoint,
                Handler = handler
            };
            _routerPoints.Add(routerPoint);
        }

        /// <summary>
        /// Обрабатывает входящий запрос и орпеделяет ему обработчик
        /// </summary>
        /// <param name="context">контекст текущего запроса</param>
        public void HandleRequest(RequestContext context)
        {
            // TODE модифицировать для совпадений end point С параметрами
            var currentEndPoint = context.GetEndPoint();
            var currentMethod = context.GetMethod();
            foreach (var routerPoint in _routerPoints)
            {
                if (currentEndPoint == routerPoint.EndPoint && currentMethod == routerPoint.Method.ToString())
                {
                    try
                    {
                        routerPoint.Handler(context);
                    }
                    catch (InvalidRequestFieldException err)
                    {
                        context.sendBadRequest(err.Message);
                    }

                    return;
                }
            }

            context.SendNotFound();
        }
    }
}
