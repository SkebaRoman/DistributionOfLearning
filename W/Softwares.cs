namespace W
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Softwares
    {
        [Key]
        public int SoftwareId { get; set; }

        public string Name { get; set; }

        public int ComputerId { get; set; }

        public int? Semester_SemesterId { get; set; }

        public virtual Computers Computers { get; set; }

        public virtual Semesters Semesters { get; set; }
    }
}
