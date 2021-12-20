using System;
using System.Collections.Generic;
using System.Data.Entity;
using ContosoUniversity.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
