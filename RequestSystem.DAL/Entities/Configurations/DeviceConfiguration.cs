using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestSystem.DAL.Entities;

namespace RequestSystem.DAL.Configurations
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable("devices");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(d => d.Brand)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(d => d.Model)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.SerialNumber)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(d => d.Owner)
                .WithMany(u => u.Devices)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.RepairRequests)
                .WithOne(r => r.Device)
                .HasForeignKey(r => r.DeviceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
