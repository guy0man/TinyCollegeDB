using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class Class
    {
        public int ClassId { get; set; }
        public int CourseId { get; set; }
        public int ProfessorId { get; set; }
        public int RoomId { get; set; }
        public string Code { get; set; }
        public string Time { get; set; }
        //Links
        public Course CourseLink { get; set; }
        public Professor ProfessorLink { get; set; }
        public Room RoomLink { get; set; }
        public ICollection<EnrollmentList> EnrollmentList { get; set; }
    }
}
