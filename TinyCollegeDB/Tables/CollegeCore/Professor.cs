using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public DateTime DateEmployed { get; set; }

        //Links
        public Department DepartmentLink { get; set; }
        public School School { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Class> Classes { get; set; }

    }
}
