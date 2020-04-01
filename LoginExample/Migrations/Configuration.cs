namespace LoginExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LoginExample.Storage.UserStorage>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoginExample.Storage.UserStorage context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(u => u.UserName, new Models.User { UserName = "thor", Role = "Student", RealName = "Thor Petersen" });
            context.Users.AddOrUpdate(u => u.UserName, new Models.User { UserName = "benn", Role = "Teacher", RealName = "Benn Christensen" });
        }
    }
}
