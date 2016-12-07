namespace W
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Computers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Computers()
        {
            Softwares = new HashSet<Softwares>();
        }

        [Key]
        public int ComputerId { get; set; }

        public string GraphicsCard { get; set; }

        public string Processor { get; set; }

        public int RAM { get; set; }

        public int AudienceId { get; set; }

        public virtual Audiences Audiences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Softwares> Softwares { get; set; }
    }
}
