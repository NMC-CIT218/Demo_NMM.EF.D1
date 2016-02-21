using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo_NMM.EF.Models
{
    public class NMMDb : DbContext
    {
        public NMMDb() : base("NMMDb")
        {

        }

        public DbSet<Brewery> Breweries { get; set; }
    }
}