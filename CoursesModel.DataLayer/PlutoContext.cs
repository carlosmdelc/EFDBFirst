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

        // The name of the connection string is different from the one in DbContext (DefaultConnection)
        // Because we have broken the convention, we need to tell EF explicitly what is the name of the connection string.
        // In the constructor call the base constructor and add the reference to the connection string name.
        public PlutoContext()
            : base("name=DefaultConnection")
        {
            
        }
    }
}

// Go to Package Manager Console and Enable migrations
// PM> enable-migrations
