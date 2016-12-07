using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public DateTime HoursOfStudy { get; set; }
        public int SemesterId { get; set; }
<<<<<<< HEAD
        public Semester Semester { get; set; }
        public int AudienceId { get; set; }
        public Audience Audince { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teacher { get; set; }
     
=======
        public int AudienceId { get; set; }
        public virtual Audience Audiences { get; set; }
        public virtual Semester Semesters { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
>>>>>>> refs/remotes/origin/master
    }
}
