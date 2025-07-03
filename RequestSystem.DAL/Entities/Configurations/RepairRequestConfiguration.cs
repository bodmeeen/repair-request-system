using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestSystem.DAL.Entities;

namespace RequestSystem.DAL.Configurations
{
    public class RepairRequestConfiguration : IEntityTypeConfiguration<RepairRequest>
    {
        public void Configure(EntityTypeBuilder<RepairRequest> builder)
        {
            builder.ToTable("repair_requests");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Description)
                .IsRequired();

            builder.Property(r => r.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.HasOne(r => r.Device)
                .WithMany(d => d.RepairRequests)
                .HasForeignKey(r => r.DeviceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.User)
                .WithMany(u => u.RepairRequests)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(r => r.Comments)
                .WithOne(c => c.RepairRequest)
                .HasForeignKey(c => c.RepairRequestId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
