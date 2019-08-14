using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.Domain.Entities
{
    public class Holiday
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Image> Images { get; set; }
        public Price Price { get; set; }
        public Location Location { get; set; }
        public HolidayType HolidayType { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateCreated{ get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
