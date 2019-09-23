using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Contracts.Models
{ 
    public class ImageDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Base64 { get; set; }
        public string SourceURL { get; set; }
    }
}
