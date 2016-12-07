namespace W
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConnectDb : DbContext
    {
        public ConnectDb()
            : base("name=ConnectDb")
        {
        }

        public virtual DbSet<Audiences> Audiences { get; set; }
        public virtual DbSet<Computers> Computers { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Semesters> Semesters { get; set; }
        public virtual DbSet<Softwares> Softwares { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Semesters>()
                .HasMany(e => e.Softwares)
                .WithOptional(e => e.Semesters)
                .HasForeignKey(e => e.Semester_SemesterId);

            modelBuilder.Entity<Semesters>()
                .HasMany(e => e.Subjects)
                .WithOptional(e => e.Semesters)
                .HasForeignKey(e => e.Semester_SemesterId);
        }
    }
}
