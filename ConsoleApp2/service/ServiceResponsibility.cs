using It_PlanetaApi.Exceptions;
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
        protected void ThrowInvalidRequestField(string? template, params object?[] args)
        {
            var message = String.Format(template??"", args);
            throw new InvalidRequestFieldException(message);
            
        }
    }
}
