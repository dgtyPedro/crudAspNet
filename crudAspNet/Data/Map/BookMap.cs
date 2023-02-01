using crudAspNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace crudAspNet.Data.Map;

public class BookMap: IEntityTypeConfiguration<BookModel>
{
    public void Configure(EntityTypeBuilder<BookModel> builder)
    {
        builder.HasKey(x => x.id);
        builder.Property(x => x.name).IsRequired().HasMaxLength(255);
        builder.Property(x => x.author).IsRequired().HasMaxLength(255);

    }
}