using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.models.animal
{
    public class CreateAnimalInput
    {
        public List<long>? AnimalTipes { get; set; }
        public float? Weight { get; set; }
        public float? Length { get; set; }
        public float? Height { get; set; }
        public string? Gender { get; set; }
        public int? ChipperId { get; set; }
        public long? ChippingLocationId { get; set; }

    }
}
