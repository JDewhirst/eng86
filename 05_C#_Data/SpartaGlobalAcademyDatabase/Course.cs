using System;
using System.Collections.Generic;

#nullable disable

namespace SpartaGlobalAcademyDatabase
{
    public partial class Course
    {
        public Course()
        {
            Trainees = new HashSet<Trainee>();
        }

        public int CourseId { get; set; }
        public int? StreamId { get; set; }
        public string CourseName { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual Stream Stream { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
