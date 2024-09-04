using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CA_TheaterDB_CodeFirst.Configuration
{
    internal class WeekConfiguration : IEntityTypeConfiguration<Week>
    {
        public void Configure(EntityTypeBuilder<Week> builder)
        {
            builder.HasMany(week => week.Theater).WithOne(theater => theater.Week).HasForeignKey(theater => theater.WeekID);
            builder.Property(week => week.ID).UseIdentityColumn();

            //Seed Data
            builder.HasData(new Week
            {
                ID = 1,
                WeekName = "Week 1",
                WakeFirstDay = new DateTime(2021, 11, 20),
                WakeLastDay = new DateTime(2024, 12, 5)
            });
        }
    }
}
