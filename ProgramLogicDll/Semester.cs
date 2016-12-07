<<<<<<< HEAD
﻿
using System.Collections.Generic;
=======
﻿using System.Collections.Generic;
>>>>>>> refs/remotes/origin/master
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Semester
    {
        [Key]
        public int SemesterId { get; set; }
        public int SemesterNumber { get; set; }
<<<<<<< HEAD
        public virtual List<Subject> Subjects { get; set; }
        public virtual List<Software> Sofwares { get; set; }
=======
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Software> Softwares { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
>>>>>>> refs/remotes/origin/master
    }
}
