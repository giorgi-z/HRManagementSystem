using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicApi.Entities;

namespace Infrastructure.Data.Config
{
    class EmployeeStatusConfiguration : IEntityTypeConfiguration<EmployeeStatus>
    {
        public void Configure(EntityTypeBuilder<EmployeeStatus> builder)
        {
            builder.HasKey(es => es.Id);

            builder.Property(es => es.Name)
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}