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
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> d)
        {
            d.ToTable("Professor");
            var professors = GenerateData();
            foreach (var professor in professors) d.HasData(professor);
        }
        private List<Professor> GenerateData()
        {
            var list = new List<Professor>();
            var faker = new Faker();
            faker.Random = new Randomizer(3333);
            for (int i = 0; i < 50; i++)
            {
                var professor = new Professor();
                professor.ProfessorId = i + 1;
                professor.DepartmentId = faker.Random.Number(1, 12);
                professor.FirstName = faker.Name.FirstName();
                professor.LastName = faker.Name.LastName();
                professor.DateEmployed = faker.Date.Past(5);
                list.Add(professor);
            }
            return list;
        }
    }
}
