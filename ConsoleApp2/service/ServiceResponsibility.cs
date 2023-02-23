using It_PlanetaApi.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service
{
    public class ServiceResponsibility
    {
        protected readonly Repository _repository;
        public ServiceResponsibility(Repository repository) 
        {
            _repository= repository;
        }
    }
}
