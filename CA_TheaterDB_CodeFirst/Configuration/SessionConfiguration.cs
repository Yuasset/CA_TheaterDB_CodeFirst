using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_TheaterDB_CodeFirst.Configuration
{
    internal class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.HasMany(session => session.Theater).WithOne(theater => theater.Session).HasForeignKey(theater => theater.SessionID);
            builder.Property(session => session.ID).UseIdentityColumn();

            //Seed Data
            builder.HasData(new Session
            {
                ID = 1,
                SessionTime = new DateTime(2024, 04, 09)
            });
        }
    }
}
