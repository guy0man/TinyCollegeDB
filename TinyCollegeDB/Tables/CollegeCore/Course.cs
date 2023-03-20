using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class Course
    {
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        //Links
        public Department DepartmentLink { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
