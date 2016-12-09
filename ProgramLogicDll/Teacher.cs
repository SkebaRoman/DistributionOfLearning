using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public virtual Group Groups { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
