using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Domain.Entities
{
    public class Price
    {
        public Guid Id { get; set; }
        public decimal KidsPrice { get; set; }
        public decimal AdultsPrice { get; set; }
        public decimal SeniorCitizenPrice { get; set; }
    }
}
