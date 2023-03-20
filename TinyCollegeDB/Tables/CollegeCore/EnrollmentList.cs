using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class EnrollmentList
    {
        public int EnrollmentListId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateEnrolled { get; set; }
        //Links
        public Class ClassLink { get; set; }
        public Student StudentLink { get; set; }
    }
}
