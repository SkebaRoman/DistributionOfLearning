using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProgramLogicDll
{
    public class Audience
    {
        [Key]
        public int AudienceId { get; set; }
        public int AudienceNumber { get; set; }
        public List<Group> Group { get; set; }
        public virtual List<Computer> Computers { get; set; }
    }
}
