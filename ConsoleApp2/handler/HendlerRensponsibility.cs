using It_PlanetaApi.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.handler
{
    
    public class HendlerRensponsibility
    {
        protected readonly Service _service;
        public HendlerRensponsibility(Service service)
        {
            _service = service;
        }
    }      
}
