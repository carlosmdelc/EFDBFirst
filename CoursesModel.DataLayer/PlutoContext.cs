using System;
using System.Collections.Generic;
using System.Data.Entity;           // Must be used when working with Entity Framework
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Classes;

namespace CodeFirstModel.DataLayer
{
    public class PlutoContext : DbContext
    {
        // DbSet is a collection of objects that represent a table in DB
        // With this we can access the Courses table in DB
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        // We are going to delete the Categories class
        // public DbSet<Category> Categories { get; set; }

        // The name of the connection string is different from the one in DbContext (DefaultConnection)
        // Because we have broken the convention, we need to tell EF explicitly what is the name of the connection string.
        // In the constructor call the base constructor and add the reference to the connection string name.
        public PlutoContext()
            : base("name=DefaultConnection")
        {
            
        }
    }
}

// Go to Package Manager Console and Enable migrations. This is only run once in the project.
// PM> enable-migrations

// Adding migration.
// After run the command you will see under the Migrations folder the script for the migration 201902210126333_ThisIsTheNameOfTheMigration.cs
// PM> add-migration ThisIsTheNameOfTheMigration

// To run migrations.
// PM> update-database


// If you add a new class and create a migration you will see nothing,
// that's because it should be added into the Context as DbSet
// add-migration AddCategoriesTable -Force      -> this to override the AddCategoriesTable migration.