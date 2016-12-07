
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Semester
    {
        [Key]
        public int SemesterId { get; set; }
        public virtual List<Subject> Subjects { get; set; }
        public virtual List<Software> Sofwares { get; set; }
    }
}
