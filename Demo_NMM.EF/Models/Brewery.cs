﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_NMM.EF.Models
{
    public class Brewery
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}