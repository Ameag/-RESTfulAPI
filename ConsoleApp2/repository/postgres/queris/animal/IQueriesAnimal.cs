using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris.animal
{
    public interface IQueriesAnimal
    {
        public string Create();
        public string CreateAnimalTipes();
        public string GetAnimalToVisitedLocation();
    }
}
