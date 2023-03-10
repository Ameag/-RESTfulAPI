using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.models.animal
{
    public class CreateAnimalInput
    {
        public long[]? id { get; set; }
        public float? weight { get; set; }
        public float? lenght { get; set; }
        public float? height { get; set; }
        public string? gender { get; set; }
        public int? chipperId { get; set; }
        public long? chippingLocationId { get; set; }

    }
}
