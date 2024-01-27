using gRPC.TaskManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gRPC.TaskManagement.DAL.ModelConfigurations;

internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(255)
            .IsRequired(false);

        builder.HasMany(x => x.Tasks)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId)
            .HasConstraintName("Fk_Category_Tasks");
    }
}