using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.Mobile.Models
{
   public class FeaturedHolidaysModel
    {
        public int FeaturedId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public  string ShortDescription { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Price { get; set; }
    }
}
