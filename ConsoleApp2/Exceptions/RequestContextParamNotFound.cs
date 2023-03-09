using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.Exceptions
{
    public class RequestContextParamNotFound:Exception
    {
        private static readonly string MESSAGE = "param is not found";
        public RequestContextParamNotFound() : base(MESSAGE) { }
    }
}
