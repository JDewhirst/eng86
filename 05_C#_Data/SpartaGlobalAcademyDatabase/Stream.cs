using System;
using System.Collections.Generic;

#nullable disable

namespace SpartaGlobalAcademyDatabase
{
    public partial class Stream
    {
        public Stream()
        {
            Courses = new HashSet<Course>();
        }

        public int StreamId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
