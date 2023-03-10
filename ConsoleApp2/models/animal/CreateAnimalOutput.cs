using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.models.animal
{
    public class CreateAnimalOutput
    {
        public long? Id { get; set; }
        public long[]? AnimalTipes { get; set; }
        public float? Weight { get; set; }
        public float? Length { get; set; }
        public float? Height { get; set; }
        public string? Gender { get; set; }
        public string? LifeStatus { get; set; }
        public string? ChippingDateTime { get; set; }

        public int? ChipperId { get; set; }
        public long? ChippingLocationId { get; set; }
        public long[]? VisitedLocations { get; set; }
        public string? DeathDateTime { get; set; }
    }
}
