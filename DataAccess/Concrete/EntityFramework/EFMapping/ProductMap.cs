using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.EFMapping
{
    public class ProductMap : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.ProductName).HasMaxLength(50);
            builder.Property(x => x.ProductName).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(180);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Price).HasColumnType("money");
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.MainImage).IsRequired();
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CategoriesId).IsRequired();
            builder.HasOne<Categories>(x => x.Categories).WithMany(c => c.Products).HasForeignKey(a => a.CategoriesId);
            builder.ToTable("Products");
        }
    }
}
