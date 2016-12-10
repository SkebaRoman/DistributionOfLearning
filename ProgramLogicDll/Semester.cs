using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Semester
    {
        [Key]
        public int SemesterId { get; set; }
        public int SemesterNumber { get; set; }
    }
}
