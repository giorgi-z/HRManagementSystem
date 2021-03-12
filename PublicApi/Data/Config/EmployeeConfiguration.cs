using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicApi.Entities;

namespace PublicApi.Data.Config
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.Property(e => e.Id)
                .IsRequired();

            builder.Property(e => e.PersonalNumber)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(e => e.BirthDate)
                .HasColumnType("date");

            builder.Property(e => e.Position)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(e => e.EndDate)
                .HasColumnType("date");

            builder.Property(e => e.ContactPhone)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasOne(e => e.EmployeeGender)
                .WithMany()
                .HasForeignKey(e => e.GenderId);

            builder.HasOne(e => e.EmployeeStatus)
                .WithMany()
                .HasForeignKey(e => e.StatusId);
        }
    }
}
