using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProgramLogicDll
{
    public class Audience
    {
        [Key]
        public int AudienceId { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public virtual List<Computer> Computers { get; set; }
    }
}
