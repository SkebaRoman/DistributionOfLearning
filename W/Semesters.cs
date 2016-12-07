namespace W
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Semesters
    {
        public Semesters()
        {
            Groups = new HashSet<Groups>();
            Softwares = new HashSet<Softwares>();
            Subjects = new HashSet<Subjects>();
        }

        [Key]
        public int SemesterId { get; set; }

        public int SemesterNumber { get; set; }

        public virtual ICollection<Groups> Groups { get; set; }

        public virtual ICollection<Softwares> Softwares { get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
