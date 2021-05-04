using System;
using System.Collections.Generic;

#nullable disable

namespace SpartaGlobalAcademyDatabase
{
    public partial class Trainee
    {
        public int TraineeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
