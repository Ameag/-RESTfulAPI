
using It_PlanetaApi.repository.postgres.queris;
using It_PlanetaApi.repository.postgres.queris.account;
using It_PlanetaApi.repository.postgres.queris.animal;
using It_PlanetaApi.repository.postgres.queris.animalType;
using It_PlanetaApi.repository.postgres.queris.location;
using repository.It_PlanetaApi.account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris
{
    public class Queries
    {
        public IQueriesAccount Account;
        public IQueriesLocation Location;
        public IQueriesAnimalType animalType;
        public IQueriesAnimal Animal;
        

        public Queries()
        {
            Account = new PostgresQueriesAccount();
            Location = new PostgresQueriesLocation();
            animalType = new PostgresQueriesAnimalType();
            Animal = new PostgresQueriesAnimal();
        }
    }


}
