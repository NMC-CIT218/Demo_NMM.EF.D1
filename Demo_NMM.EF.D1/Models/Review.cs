﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_NMM.EF.D1.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Content { get; set; }

        public int BreweryID { get; set; }
    }
}