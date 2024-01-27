using gRPC.TaskManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gRPC.TaskManagement.DAL.ModelConfigurations;

internal class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
{
    public void Configure(EntityTypeBuilder<TaskItem> builder)
    {
        builder.ToTable("Tasks");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(50)
            .HasAnnotation("MinLength", 3)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(250)
            .IsRequired(false);

        builder.HasMany(x => x.Comments)
            .WithOne(c => c.TaskItem)
            .HasForeignKey(c => c.TaskItemId)
            .HasConstraintName("Fk_Task_Commnets");
    }
}