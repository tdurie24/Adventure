using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Contracts.Models
{
    public class EventDto
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PriceDto Price { get; set; }
        public LocationDto Location { get; set; }
        public CoordinatorDto Coordinator { get; set; }
        public IEnumerable<ImageDto> Images { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
 