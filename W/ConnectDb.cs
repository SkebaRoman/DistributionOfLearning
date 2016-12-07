namespace W
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ProgramLogicDll;
    public class ConnectDb : DbContext
    {
        public ConnectDb()
            : base("name=DistributionOfLearningDB")
        {
        }

      

         public virtual DbSet<Audience> Audiences { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }


    }

}