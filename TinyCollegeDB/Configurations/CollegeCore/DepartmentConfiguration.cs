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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> d)
        {
            d.ToTable("Department");
            d.HasData(new Department { DepartmentId= 1, Name= "Accounting Department", SchoolId= 1 });
            d.HasData(new Department { DepartmentId= 2, Name= "Management Department", SchoolId= 1 });
            d.HasData(new Department { DepartmentId= 3, Name= "Entrepreneurship Department", SchoolId= 1 });
            d.HasData(new Department { DepartmentId= 4, Name= "Medical Biology Department", SchoolId= 2 });
            d.HasData(new Department { DepartmentId= 5, Name= "Pschology Department", SchoolId= 2 });
            d.HasData(new Department { DepartmentId= 6, Name= "Computer Science Department", SchoolId= 2 });
            d.HasData(new Department { DepartmentId= 7, Name= "Elementary Education Department", SchoolId= 3 });
            d.HasData(new Department { DepartmentId= 8, Name= "Secondary Education in Mathematics Department", SchoolId= 3 });
            d.HasData(new Department { DepartmentId= 9, Name= "Secondary Education in Science Department", SchoolId= 3 });
            d.HasData(new Department { DepartmentId= 10, Name= "Computer Engineering Department", SchoolId= 4 });
            d.HasData(new Department { DepartmentId= 11, Name= "Electrical Engineering Department", SchoolId= 4 });
            d.HasData(new Department { DepartmentId= 12, Name= "Robotics Engineering Department", SchoolId= 4 });
        }
    }
}
