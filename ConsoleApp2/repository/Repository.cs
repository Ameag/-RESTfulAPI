
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using It_PlanetaApi.repository.animal;
using It_PlanetaApi.repository.animalType;
using It_PlanetaApi.repository.location;
using It_PlanetaApi.repository.postgres.queris;
using repository.It_PlanetaApi.account;
using repository.postgres;

namespace It_PlanetaApi.repository
{
    public class Repository
    {
        public IAccount Account;
        public ILocation Location;
        public IAnimalType AnimalType;
        public IAnimal Animal;

        public Repository(PostgresDatabase database) 
        {
            var queries = new Queries();
            Account = new Account(database, queries);
            Location = new Location(database, queries);
            AnimalType= new AnimalType(database, queries);
            Animal = new Animal(database, queries);
        }
    }
}
