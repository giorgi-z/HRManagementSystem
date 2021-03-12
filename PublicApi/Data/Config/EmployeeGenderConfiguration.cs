using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicApi.Entities;

namespace PublicApi.Data.Config
{
    public class EmployeeGenderConfiguration : IEntityTypeConfiguration<EmployeeGender>
    {
        public void Configure(EntityTypeBuilder<EmployeeGender> builder)
        {
            builder.HasKey(eg => eg.Id);

            builder.Property(eg => eg.Name)
                .HasMaxLength(6)
                .IsRequired();
        }
    }
}
