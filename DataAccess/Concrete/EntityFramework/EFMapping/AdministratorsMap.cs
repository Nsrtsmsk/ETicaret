using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.EFMapping
{
    public class AdministratorsMap : IEntityTypeConfiguration<Administrators>
    {
        public void Configure(EntityTypeBuilder<Administrators> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Surname).IsRequired();
            builder.Property(c => c.Surname).HasMaxLength(50);

            builder.Property(c => c.EMail).IsRequired();
            builder.Property(c => c.EMail).HasMaxLength(80);
            builder.Property(c => c.Phone).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(15);
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.Password).IsRequired();
            builder.Property(c => c.Password).HasMaxLength(30);
            builder.ToTable("Administrators");
        }
    }
}
