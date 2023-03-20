using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class Room
    {
        public int RoomId { get; set; }
        public int BuildingId { get; set; }
        public string Code { get; set; }
        //Links
        public Building BuildingLink { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
