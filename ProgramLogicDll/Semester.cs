using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogicDll
{
    public class Semester
    {
        public int Id { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Software> Sofwares { get; set; }
    }
}
