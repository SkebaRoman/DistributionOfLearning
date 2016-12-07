using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
=======

>>>>>>> refs/remotes/origin/master
namespace ProgramLogicDll
{
    public class Audience
    {
        [Key]
        public int AudienceId { get; set; }
        public int AudienceNumber { get; set; }
<<<<<<< HEAD
        public List<Group> Group { get; set; }
        public virtual List<Computer> Computers { get; set; }
=======
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
>>>>>>> refs/remotes/origin/master
    }
}
