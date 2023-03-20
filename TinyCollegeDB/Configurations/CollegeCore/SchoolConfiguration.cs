using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCollegeDB.Tables.CollegeCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TinyCollegeDB.Configurations.CollegeCore
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> d)
        {
            d.ToTable("School");
            d.HasData(new School { SchoolId= 1, Name= "School of Business", ProfessorId= 1 });
            d.HasData(new School { SchoolId= 2, Name= "School of Arts and Sciences", ProfessorId = 4 });
            d.HasData(new School { SchoolId= 3, Name= "School of Education", ProfessorId = 5});
            d.HasData(new School { SchoolId= 4, Name= "School of Applied Sciences", ProfessorId = 10 });          
        }
    }
}
