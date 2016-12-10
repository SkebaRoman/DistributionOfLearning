using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Software
    {
        [Key]
        public int SoftwareId { get; set; }
        public string Name { get; set; }
        public virtual Computer Computers { get; set; }
        public virtual Semester Semesters { get; set; }
    }
}
