using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestSystem.DAL.Entities;

namespace RequestSystem.DAL.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("comments");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Text)
                .IsRequired();

            builder.HasOne(c => c.RepairRequest)
                .WithMany(r => r.Comments)
                .HasForeignKey(c => c.RepairRequestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
