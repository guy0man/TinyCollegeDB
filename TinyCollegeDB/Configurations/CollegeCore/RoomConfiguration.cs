using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCollegeDB.Tables.CollegeCore;
using Bogus;

namespace TinyCollegeDB.Configurations.CollegeCore
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> d)
        {
            d.ToTable("Room");
            var rooms = GenerateData();
            foreach (var room in rooms) d.HasData(room);
        }
        private List<Room> GenerateData()
        {           
            var list = new List<Room>();
            var faker = new Faker();
            faker.Random = new Randomizer(3333);
            for (int i = 0; i < 200; i++)
            {
                var room = new Room();
                room.RoomId = i + 1;
                room.BuildingId = faker.Random.Number(1, 3);
                room.Code = faker.Random.Digits(4).ToString();              
                list.Add(room);
            }
            return list;
        }
    }
}
