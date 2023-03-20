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
    public class EnrollmentListConfiguration : IEntityTypeConfiguration<EnrollmentList>
    {
        public void Configure(EntityTypeBuilder<EnrollmentList> d)
        {
            d.ToTable("EnrollmentList");
            var erollments = GenerateData();
            foreach(var enrollment in erollments) d.HasData(enrollment);
        }
        private List<EnrollmentList> GenerateData()
        {            
            var list = new List<EnrollmentList>();
            var faker = new Faker();
            faker.Random = new Randomizer(3333);
            for (int i = 0; i < 2000; i++)
            {
                var enrollment = new EnrollmentList();
                enrollment.EnrollmentListId = i + 1;
                enrollment.ClassId = faker.Random.Number(1, 120);
                enrollment.StudentId = faker.Random.Number(1, 500);
                enrollment.DateEnrolled = faker.Date.Past();                
                list.Add(enrollment);
            }
            return list;
        }
    }
}
