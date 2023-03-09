using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris.location
{
    public class PostgresQueriesLocation : IQueriesLocation
    {
        public string Create()
        {
            return "INSERT INTO \"LocationPoint\"(latitude,longitude) VALUES ($1,$2) RETURNING*";
        }
        public string GetInfoLocation()
        {
            return "SELECT * FROM \"LocationPoint\" WHERE id = $1 ";
        }
    }
}
