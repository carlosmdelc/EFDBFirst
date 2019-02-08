using System.Collections.Generic;

namespace Courses.Classes
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // We have one to many relationship between Authors and Courses
        // An Author may have many Courses
        // Each Course is created only by one Author
        public IList<Course> Courses { get; set; }
    }
}