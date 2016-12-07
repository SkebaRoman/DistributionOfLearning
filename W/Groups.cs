namespace W
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Groups
    {
       
        public Groups()
        {
            Students = new HashSet<Students>();
            Teachers = new HashSet<Teachers>();
        }

        [Key]
        public int GroupId { get; set; }

        public string Name { get; set; }

        public string Profession { get; set; }

        public DateTime HoursOfStudy { get; set; }

        public int SemesterId { get; set; }

        public int AudienceId { get; set; }

        public virtual Audiences Audiences { get; set; }

        public virtual Semesters Semesters { get; set; }
        public virtual ICollection<Students> Students { get; set; }
        public virtual ICollection<Teachers> Teachers { get; set; }
    }
}
