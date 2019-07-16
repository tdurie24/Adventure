﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Domain.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Base64 { get; set; }
    }
}
