namespace Demo_NMM.EF.D1.Migrations
{
    using Demo_NMM.EF.D1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<Demo_NMM.EF.D1.Models.NMMDb_D1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Demo_NMM.EF.D1.Models.NMMDb_D1";
        }

        protected override void Seed(Demo_NMM.EF.D1.Models.NMMDb_D1 context)
        {
            context.Breweries.AddOrUpdate(b => b.Name,
                    new Brewery
                    {
                        Name = "Johnny's Hops",
                        City = "Empire",
                        State = "MI",
                    },
                    new Brewery
                    {
                        Name = "Billy's Brew",
                        City = "Empire",
                        State = "MI"
                    },
                    new Brewery
                    {
                        Name = "Suzy's Suds",
                        City = "Empire",
                        State = "MI"
                    }
                );
        }
    }
}
