﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public virtual Semester Semesters { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
