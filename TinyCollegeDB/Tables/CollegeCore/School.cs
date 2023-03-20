using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class School
    {
        public int SchoolId { get; set; }
        public int ProfessorId { get; set; }
        public string Name { get; set; }
        //Links
        public Professor Dean { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
