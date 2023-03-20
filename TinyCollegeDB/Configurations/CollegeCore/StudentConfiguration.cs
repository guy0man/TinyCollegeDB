using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCollegeDB.Tables.CollegeCore;
using Bogus;

namespace TinyCollegeDB.Configurations.CollegeCore
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> d)
        {
            d.ToTable("Student");
            var students = GenerateData();
            foreach (var student in students) d.HasData(student);
        }
        private List<Student> GenerateData()
        {
            List<string> majors = new List<string>() { "Accounting", "Management", "Entreprenuership", "Medical Biology", "Psychology", 
                "Computer Science", "Elementary Education", "Secondary Education in Mathematics", "Secondary Education in Science",
                "Computer Engineering", "Electrical Engineering", "Robotics Engineering"};
            var list = new List<Student>();
            var faker = new Faker();
            faker.Random = new Randomizer(3333);
            for (int i = 0; i < 500; i++)
            {
                var student = new Student();
                student.StudentId = i + 1;
                student.DepartmentId = faker.Random.Number(1, 12);
                student.ProfessorId = faker.Random.Number(1, 50);
                student.FirstName = faker.Name.FirstName();
                student.LastName = faker.Name.LastName();
                student.DateOfBirth = faker.Date.Past(18, DateTime.Today);
                student.SchoolYearEnrolled = faker.Date.Past(1, DateTime.Today).ToString();
                student.Major = faker.Random.ListItem(majors);
                list.Add(student);
            }
            return list;
        }
    }
}
