using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogicDll
{
    public class Audience
    {
        public int Id { get; set; }
        public Group Group { get; set; }
        public List<Computer> Computers { get; set; }
    }
}
