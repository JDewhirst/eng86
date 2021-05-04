using System;
using System.Collections.Generic;

#nullable disable

namespace SpartaGlobalAcademyDatabase
{
    public partial class TrainerCourse
    {
        public int? TrainerId { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
