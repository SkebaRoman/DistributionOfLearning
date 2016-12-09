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
        public Semester Semester { get; set; }
        public int AudienceId { get; set; }
        public Audience Audince { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
