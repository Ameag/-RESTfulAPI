using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.animal
{
    public interface IAnimal
    {
        public PostgresAnimal Create(float? weight, float? lenght, float? height, string? gender, int? chipperId, long? chippingLocationId);
        public void CreateAnimalTipes(List<long>? animalTipes,long? id);
        public void GetAnimalToVisitedLocation(long? id);
    }
}
