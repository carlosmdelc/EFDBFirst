using System.Collections.Generic;

namespace CodeFirst.Classes
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // A Tag may apply to many Courses
        // A Course may have multiple Tags
        // Many to many relationship
        public IList<Course> Courses { get; set; }
    }
}