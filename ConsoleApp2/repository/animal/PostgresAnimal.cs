using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.animal
{
    public class PostgresAnimal
    {
        [PostgresName("id")]
        public long? Id { get; set; }
        [PostgresName("weight")]
        public float? Weight { get; set; }
        [PostgresName("length")]
        public float? Length { get; set; }
        [PostgresName("height")]
        public float? Height { get; set; }
        [PostgresName("gender")]
        public string? Gender { get; set; }
        [PostgresName("life_status")]
        public string? LifeStatus { get; set; }
        [PostgresName("chipping_date")]
        public string? ChippingDateTime { get; set; }
        [PostgresName("chipper")]
        public int? ChipperId { get; set; }
        [PostgresName("chipping_location")]
        public long? ChippingLocationId { get; set; }
        [PostgresName("death_date")]
        public string? DeathDateTime { get; set; }
    }
}
