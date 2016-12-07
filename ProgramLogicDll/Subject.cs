<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
=======
﻿using System.ComponentModel.DataAnnotations;

>>>>>>> refs/remotes/origin/master
namespace ProgramLogicDll
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
<<<<<<< HEAD
=======
        public int? Semester_SemesterId { get; set; }
        public virtual Semester Semesters { get; set; }
>>>>>>> refs/remotes/origin/master
        public virtual Teacher Teachers { get; set; }
    }
}
