﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Web.API.Models
{
    public class Image
    {
        public Guid ImagesId { get; set; }
        public string Name { get; set; }
        public string Base64 { get; set; }
    }
}