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
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        // Navigation property to the Author type
        // Each Course is created only by one Author
        public Author Author { get; set; }
        // Course may have multiple Tags
        public IList<Tag> Tags { get; set; }
    }
}