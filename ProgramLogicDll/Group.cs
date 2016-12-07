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
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}
