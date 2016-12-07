using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Audience
    {
        [Key]
        public int AudienceId { get; set; }
        public int AudienceNumber { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
