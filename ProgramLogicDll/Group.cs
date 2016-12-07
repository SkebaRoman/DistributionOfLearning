using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogicDll
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public DateTime HoursOfStudy { get; set; }
        public Semester Semester { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}
