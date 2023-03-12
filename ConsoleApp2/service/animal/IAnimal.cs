using It_PlanetaApi.models.animal;
using It_PlanetaApi.repository.account;
using It_PlanetaApi.repository.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service.animal
{
    public interface IAnimal
    {
        public PostgresAnimal Create(CreateAnimalInput props);
    }
}
