using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Web.API.Models
{
    public class Price
    {
        public Guid PriceID { get; set; }
        public decimal KidsPrice { get; set; }
        public decimal AdultsPrice { get; set; }
        public decimal SeniorCitizenPrice { get; set; }
    }
}
