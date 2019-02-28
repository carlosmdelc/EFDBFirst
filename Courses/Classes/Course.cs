using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using CodeFirst.Enums;

namespace CodeFirst.Classes
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DatePublished { get; set; }        // Because we use DateTime here when we create a migration this field will be
                                                            // a required column, is not going to be Nullable because the DateTime type is a 
                                                            // structure and it cannot be NULL. If you want to make this field NULLABLE we use ? sign
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        // Navigation property to the Author type
        // Each Course is created only by one Author
        public Author Author { get; set; }
        // Course may have multiple Tags
        public IList<Tag> Tags { get; set; }
    }
}