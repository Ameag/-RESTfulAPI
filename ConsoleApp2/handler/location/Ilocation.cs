using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.handler.location
{
    public interface Ilocation 
    {
        public void Create(RequestContext context) 
        { 

        }
        public void GetInfoLocation(RequestContext context) { }
    }
}
