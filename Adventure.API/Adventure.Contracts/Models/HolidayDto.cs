using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.Contracts.Models
{
    public class HolidayDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<ImageDto> Images { get; set; }
        public PriceDto Price { get; set; }
        public LocationDto Location { get; set; }
        public HolidayTypeDto HolidayType { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsFeatured { get; set; }
    }
}
