using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProgramLogicDll
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teachers { get; set; }
    }
}
