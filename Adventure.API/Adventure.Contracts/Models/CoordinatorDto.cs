﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Contracts.Models
{
    public class CoordinatorDto
    {
        public Guid CoordinatorID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string CellPhone { get; set; }
        public string PhoneNumber { get; set; }
    }
}