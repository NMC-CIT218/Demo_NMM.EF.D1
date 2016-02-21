using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Demo_NMM.EF.D1.Models
{
    public class NMMDb_D1 : DbContext
    {
        public NMMDb_D1()
            : base("NMMDb_D1")
        {

        }

        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}