using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public int SchoolId { get; set; }
        public int ProfessorId { get; set; }
        public string Name { get; set; }

        //links
        public School SchoolLink { get; set; }
        public Professor Chair { get; set; }
        public ICollection<Professor> Professors { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
