namespace Assignment9.Migrations
{
    using Assignment9.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment9.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Assignment9.Models.GameDBContext";
        }

        protected override void Seed(Assignment9.Models.GameDBContext context)
        {

            context.Games.AddOrUpdate(i => i.Title,
                new Game { 
                    Title = "Ico",
                    ReleaseDate = DateTime.Parse("1/1/2001"),
                    Genre = "Fantasy",
                    Price = 19.99M,
                    esrbRating = "T",
                    Description = "Udea's greatest accomplishment on the PS2",
                    Developer = "Team ICO",
                    Publisher = "Sony",
                    Score = 10
                         }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
