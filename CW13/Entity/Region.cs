﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW13.Entity
{
    public class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public List<Territory> Territories { get; set; }
    }
}
