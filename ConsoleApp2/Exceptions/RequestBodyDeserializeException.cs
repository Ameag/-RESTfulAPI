using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.Exceptions
{
    public class RequestBodyDeserializeException: Exception
    {
        private static readonly string MESSAGE = "requset body deserialize error";
        public RequestBodyDeserializeException() : base(MESSAGE) { }
        
    }
}
