using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeDB.Tables.CollegeCore
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string Name { get; set; }
        //links
        ICollection<Room> Rooms { get; set; }
    }
}
