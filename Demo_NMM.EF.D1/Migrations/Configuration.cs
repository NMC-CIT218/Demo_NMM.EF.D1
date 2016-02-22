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
                        Address = "123 IPA Lane",
                        City = "Empire",
                        State = "MI",
                        Zip = "11111"
                    },
                    new Brewery
                    {
                        Name = "Billy's Brew",
                        Address = "321 Porter Street",
                        City = "Empire",
                        State = "MI",
                        Zip = "22222"
                    },
                    new Brewery
                    {
                        Name = "Suzy's Suds",
                        Address = "231 Ale Isle",
                        City = "Empire",
                        State = "MI",
                        Zip = "33333"
                    }
                );
        }
    }
}
