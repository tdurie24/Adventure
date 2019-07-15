using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Contracts.Models
{
    public class Location
    {
        public Guid LocationId { get; set; }
        public string Surburb { get; set; }
        public string Town { get; set; }
        public string  Province { get; set; }
        public string Country { get; set; }
        public GeoCoordinate GpsLocation { get; set; }
    }
}
