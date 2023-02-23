using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.Exceptions
{
    public class InvalidRequestFieldException: Exception
    {
        public InvalidRequestFieldException(string message) : base (message) 
        {

        }
    }
}
