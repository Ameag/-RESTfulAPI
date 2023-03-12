using It_PlanetaApi.repository.postgres.queris;
using It_PlanetaApi.repository.postgres.queris.animalToType;
using repository.postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.animal
{
    public class Animal : RepositoryResponsibility, IAnimal
    {

        public Animal(PostgresDatabase database, Queries queries) : base(database, queries)
        {
        }

        public PostgresAnimal Create(float? weight, float? lenght, float? height, string? gender, int? chipperId, long? chippingLocationId)
        {
            string lifeStatus = "ALIVE";
            var query = Queries.Animal.Create();
            return GetResultObject<PostgresAnimal>(query,weight,lenght,height,gender,chipperId,chippingLocationId,lifeStatus);
        }

        public void CreateAnimalTipes(List<long> animalTipes,long? id)
        {
            var query = Queries.Animal.CreateAnimalTipes();
            for(int x = 0;x<animalTipes.Count;x++) 
            {
               GetResultObject<PostgresAnimalToType>(query, animalTipes[x],id);
            }
        }
        public void GetAnimalToVisitedLocation(long? id)
        {
            var query = Queries.Animal.GetAnimalToVisitedLocation();
            GetResultObject<PostgresAnimalToType>(query, id);
            
        }
    }
}
