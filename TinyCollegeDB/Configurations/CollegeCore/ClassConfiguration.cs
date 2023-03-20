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
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> d)
        {
            d.ToTable("Class");
            var Classes = GenerateData();
            foreach (var c in Classes) d.HasData(c);
        }
        private List<Class> GenerateData()
        {
            var list = new List<Class>();
            var faker = new Faker();
            faker.Random = new Randomizer(3333);
            int courseIdHelper = 1;
            int _classIdHelper = 1;
            for (int a = 0; a < 60; a++)
            {           
                for (int i = 0; i < 2; i++)
                {
                    var _class = new Class();
                    _class.ClassId = _classIdHelper;
                    _class.CourseId = courseIdHelper;
                    _class.ProfessorId = faker.Random.Number(1,50);
                    _class.RoomId = faker.Random.Number(1,100);
                    _class.Code = faker.Random.Digits(4).ToString();
                    list.Add(_class);   
                    _classIdHelper++;
                }
                courseIdHelper++;
            }           
            return list;
        }
    }
}
