namespace W
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teachers
    {
        public Teachers()
        {
            Subjects = new HashSet<Subjects>();
        }

        [Key]
        public int TeacherId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }

        public int GroupId { get; set; }

        public virtual Groups Groups { get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
