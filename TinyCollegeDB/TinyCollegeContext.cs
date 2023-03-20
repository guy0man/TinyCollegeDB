using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCollegeDB.Tables.CollegeCore;
using Microsoft.EntityFrameworkCore;
using TinyCollegeDB.Configurations.CollegeCore;

namespace TinyCollegeDB
{
    public class TinyCollegeContext
    {
        protected void OnConfiguring(DbContextOptionsBuilder op)
        {
            if (!op.IsConfigured) op.UseSqlServer(@"Server=DESKTOP-A35B2UL\TACO;Initial Catalog=TinyCollegeDB;Trusted_Connection=True");
        }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EnrollmentList> EnrollmentLists { get; set; }
        public DbSet <Professor> Professors { get; set;}
        public DbSet<Room> Rooms { get; set; }
        public DbSet<School> Schools { get; set; } 
        public DbSet<Student> Students { get; set; }
        protected void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfiguration(new BuildingConfiguration());
            mb.ApplyConfiguration(new ClassConfiguration());
            mb.ApplyConfiguration(new CourseConfiguration());
            mb.ApplyConfiguration(new DepartmentConfiguration());
            mb.ApplyConfiguration(new EnrollmentListConfiguration());
            mb.ApplyConfiguration(new ProfessorConfiguration());
            mb.ApplyConfiguration(new RoomConfiguration());
            mb.ApplyConfiguration(new SchoolConfiguration());
            mb.ApplyConfiguration(new StudentConfiguration());
        }
    }
}
