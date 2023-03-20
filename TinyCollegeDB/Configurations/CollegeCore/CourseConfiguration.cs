using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCollegeDB.Tables.CollegeCore;

namespace TinyCollegeDB.Configurations.CollegeCore
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> d)
        {
            d.ToTable("Course");
            d.HasData(new Course { CourseId = 1, DepartmentId= 1, Name= "Financial Accounting and Reporting"});
            d.HasData(new Course { CourseId = 2, DepartmentId= 1, Name= "Conceptual Framework and Accounting"});
            d.HasData(new Course { CourseId = 3, DepartmentId= 1, Name= "Cost Accounting and Control"});
            d.HasData(new Course { CourseId = 4, DepartmentId= 1, Name= "Intermediate Accounting 1"});
            d.HasData(new Course { CourseId = 5, DepartmentId= 1, Name= "IT Application Tool in Business"});
            d.HasData(new Course { CourseId = 6, DepartmentId= 2, Name= "Managenment and Organization"});
            d.HasData(new Course { CourseId = 7, DepartmentId= 2, Name= "Organizational Communication & Presentation"});
            d.HasData(new Course { CourseId = 8, DepartmentId= 2, Name= "Income and Business Taxation"});
            d.HasData(new Course { CourseId = 9, DepartmentId= 2, Name= "Management Information System"});
            d.HasData(new Course { CourseId = 10, DepartmentId= 2, Name= "Good Governance and Social Responsibility"});
            d.HasData(new Course { CourseId = 11, DepartmentId= 3, Name= "Agribusiness"});
            d.HasData(new Course { CourseId = 12, DepartmentId= 3, Name= "Manufacturing Process Management"});
            d.HasData(new Course { CourseId = 13, DepartmentId= 3, Name= "Food, Tourism, and Service"});
            d.HasData(new Course { CourseId = 14, DepartmentId= 3, Name= "Entrepreneurship Behavior"});
            d.HasData(new Course { CourseId = 15, DepartmentId= 3, Name= "Social Entrepreneurship"});
            d.HasData(new Course { CourseId = 16, DepartmentId= 4, Name= "General Biology"});
            d.HasData(new Course { CourseId = 17, DepartmentId= 4, Name= "General Zoology"});
            d.HasData(new Course { CourseId = 18, DepartmentId= 4, Name= "Systematics"});
            d.HasData(new Course { CourseId = 19, DepartmentId= 4, Name= "Evolutionary Biology"});
            d.HasData(new Course { CourseId = 20, DepartmentId= 4, Name= "General Ecology"});
            d.HasData(new Course { CourseId = 21, DepartmentId= 5, Name= "Introduction to Psychology and Learning"});
            d.HasData(new Course { CourseId = 22, DepartmentId= 5, Name= "Psychological Statistics"});
            d.HasData(new Course { CourseId = 23, DepartmentId= 5, Name= "Developmental Psychology"});
            d.HasData(new Course { CourseId = 24, DepartmentId= 5, Name= "Physiological Psychology"});
            d.HasData(new Course { CourseId = 25, DepartmentId= 5, Name= "Theories of Personality"});
            d.HasData(new Course { CourseId = 26, DepartmentId= 6, Name= "Introduction to Computing"});
            d.HasData(new Course { CourseId = 27, DepartmentId= 6, Name= "Computer Programming 1"});
            d.HasData(new Course { CourseId = 28, DepartmentId= 6, Name= "Discrete Structures 1"});
            d.HasData(new Course { CourseId = 29, DepartmentId= 6, Name= "Computer Programming 2"});
            d.HasData(new Course { CourseId = 30, DepartmentId= 6, Name= "Discrete Structures 2"});
            d.HasData(new Course { CourseId = 31, DepartmentId= 7, Name= "Teaching Science in the Elementary Grades"});
            d.HasData(new Course { CourseId = 32, DepartmentId= 7, Name= "Teaching Math in the Elementary Grades"});
            d.HasData(new Course { CourseId = 33, DepartmentId= 7, Name= "Teaching Social Studies in the Elementary Grades"});
            d.HasData(new Course { CourseId = 34, DepartmentId= 7, Name= "Teaching PE and Health in the Elementary Grades"});
            d.HasData(new Course { CourseId = 35, DepartmentId= 7, Name= "Teaching PE and Math in the Intermediate Grades"});
            d.HasData(new Course { CourseId = 36, DepartmentId= 8, Name= "College and Advanced Algebra"});
            d.HasData(new Course { CourseId = 37, DepartmentId= 8, Name= "Trigonometry"});
            d.HasData(new Course { CourseId = 38, DepartmentId= 8, Name= "Plane and Solid Geometry"});
            d.HasData(new Course { CourseId = 39, DepartmentId= 8, Name= "Calculus 1 with Analytic Geometry"});
            d.HasData(new Course { CourseId = 40, DepartmentId= 8, Name= "Logic and Set Theory"});
            d.HasData(new Course { CourseId = 41, DepartmentId= 9, Name= "Environmental Science for Science Education"});
            d.HasData(new Course { CourseId = 42, DepartmentId= 9, Name= "Microbiology and Parasitology for Science"});
            d.HasData(new Course { CourseId = 43, DepartmentId= 9, Name= "Thermodynamics"});
            d.HasData(new Course { CourseId = 44, DepartmentId= 9, Name= "Fluid Mechanics"});
            d.HasData(new Course { CourseId = 45, DepartmentId= 9, Name= "Anatomy and Physiology for Science Education"});
            d.HasData(new Course { CourseId = 46, DepartmentId= 10, Name= "Programming Logic and Design"});
            d.HasData(new Course { CourseId = 47, DepartmentId= 10, Name= "Object-Oriented Programming"});
            d.HasData(new Course { CourseId = 48, DepartmentId= 10, Name= "Computer Engineering as a Discipline"});
            d.HasData(new Course { CourseId = 49, DepartmentId= 10, Name= "Data Structures and Algorithms"});
            d.HasData(new Course { CourseId = 50, DepartmentId= 10, Name= "Software Design"});
            d.HasData(new Course { CourseId = 51, DepartmentId= 11, Name= "Building Wiring Technology and Motor Controls"});
            d.HasData(new Course { CourseId = 52, DepartmentId= 11, Name= "Electrical Circuits"});
            d.HasData(new Course { CourseId = 53, DepartmentId= 11, Name= "Electrical Circuits 2"});
            d.HasData(new Course { CourseId = 54, DepartmentId= 11, Name= "Electromagnetics"});
            d.HasData(new Course { CourseId = 55, DepartmentId= 11, Name= "Egineering Mathematics for EE"});
            d.HasData(new Course { CourseId = 56, DepartmentId= 12, Name= "Shielded Metal Arc Welding"});
            d.HasData(new Course { CourseId = 57, DepartmentId= 12, Name= "Technical Drafting"});
            d.HasData(new Course { CourseId = 58, DepartmentId= 12, Name= "Building Electrical Wiring"});
            d.HasData(new Course { CourseId = 59, DepartmentId= 12, Name= "Basic Machining"});
            d.HasData(new Course { CourseId = 60, DepartmentId= 12, Name= "Programming Logic and Design"});          
        }
    }
}
