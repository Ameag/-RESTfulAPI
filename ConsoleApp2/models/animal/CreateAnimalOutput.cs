using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.models.animal
{
    public class CreateAnimalOutput
    {
        public long[]? id { get; set; }
        public float? weight { get; set; }
        public float? lenght { get; set; }
        public float? height { get; set; }
        public string? gender { get; set; }
        public string? lifeStatus { get; set; }
        //public DateTime? chippingDateTime { get; set; }

        public int? chipperId { get; set; }
        public long? chippingLocationId { get; set; }
        public long[]? visitedLocations { get; set; }
        //public DateTime? deathDateTime { get; set; }
    }
}
