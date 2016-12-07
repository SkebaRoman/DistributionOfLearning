using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Semester
    {
        [Key]
        public int SemesterId { get; set; }
        public int SemesterNumber { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Software> Softwares { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
