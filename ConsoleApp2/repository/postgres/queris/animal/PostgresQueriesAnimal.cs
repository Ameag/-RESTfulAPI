using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris.animal
{
    public class PostgresQueriesAnimal : IQueriesAnimal
    {
        public string Create()
        {
            return "INSERT INTO \"Animal\" (weight,length,height,gender,chipper,chipping_location,life_status,chipping_date)" +
                "VALUES ($1,$2,$3,$4,$5,$6,$7,now()) RETURNING *";
        }

        public string CreateAnimalTipes()
        {
            return "INSERT INTO \"AnimalToType\" (animal,type)" +
                "VALUES ($1,$2) RETURNING*";
        }

        public string GetAnimalToVisitedLocation()
        {
            return "SELECT location \"AnimalVisitedLocation\" WHERE id = $1";
        }
    }
}
