namespace W
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subjects
    {
        [Key]
        public int SubjectId { get; set; }

        public string Name { get; set; }

        public int TeacherId { get; set; }

        public int? Semester_SemesterId { get; set; }

        public virtual Semesters Semesters { get; set; }

        public virtual Teachers Teachers { get; set; }
    }
}
