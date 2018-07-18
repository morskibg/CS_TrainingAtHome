

using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Data.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(50).IsUnicode().IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsUnicode().IsRequired();
            builder.Property(x => x.ReleaseDate).IsRequired(false);
            builder.HasMany(x => x.BookCategories).WithOne(x => x.Book).HasForeignKey(x => x.BookID);
        }
    }
}
