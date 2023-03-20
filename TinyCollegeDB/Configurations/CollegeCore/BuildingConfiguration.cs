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
    public class BuildingConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> d)
        {
            d.ToTable("Building");
            d.HasData(new Building { BuildingId= 1, Name= "Elysium" });
            d.HasData(new Building { BuildingId= 2, Name= "Valhalla" });
            d.HasData(new Building { BuildingId= 3, Name= "Reeds" });

        }       
    }
}
