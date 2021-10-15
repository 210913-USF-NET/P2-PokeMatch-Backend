﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Element
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ElementGroupId { get; set; }

        ElementGroup ElementGroups { get; set; }
    }
}