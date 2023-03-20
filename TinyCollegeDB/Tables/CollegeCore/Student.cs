using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class Student
    {
        public int StudentId { get; set; }
        public int ProfessorId { get; set; }
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SchoolYearEnrolled { get; set; }
        public string Major { get; set; }
        //Links
        public ICollection<EnrollmentList> EnrollmentLists { get; set; }
        public Professor ProfessorLink { get; set; }
        public Department DepartmentLink { get; set; }
    }
}
