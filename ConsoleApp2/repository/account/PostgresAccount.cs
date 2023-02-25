using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.account
{
    public class PostgresAccount
    {
        [PostgresName("id")]
        public long Id { get; set; }
        [PostgresName("first_name")]
        public string FirstName { get; set; }
        [PostgresName("last_name")]
        public string LastName { get; set; }
        [PostgresName("email")]
        public string Email { get; set; }
        [PostgresName("password")]
        public string Password { get; set; }

    }
}
