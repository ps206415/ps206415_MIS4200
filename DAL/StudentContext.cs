using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ps206415_MIS4200.Models;

namespace ps206415_MIS4200.DAL
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentContext, ps206415_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }

    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);
    //}

}