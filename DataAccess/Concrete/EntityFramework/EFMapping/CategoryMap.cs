using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.EFMapping
{
    public class CategoryMap : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(x => x.Id);// Primary Key
            builder.Property(x => x.Id).ValueGeneratedOnAdd();// Otomatik Artan.
            builder.Property(x => x.CategoryName).HasMaxLength(180);
            builder.Property(x => x.CategoryName).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.ToTable("Categories");
        }
    }
}
