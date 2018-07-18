

using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Data.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsUnicode().IsRequired();
            builder.HasMany(x => x.CategoryBooks).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
        }
    }
}
