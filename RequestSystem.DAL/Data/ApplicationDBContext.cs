using Microsoft.EntityFrameworkCore;
using RequestSystem.DAL.Configurations;
using RequestSystem.DAL.Entities;
using RequestSystem.DAL.Entities.Configurations;
using System;

namespace RequestSystem.DAL.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new RepairRequestConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin",
                    Email = "admin@example.com",
                    PasswordHash = "hashedpassword1",
                    PhoneNumber = "1234567890",
                    Role = UserRole.Admin
                },
                new User
                {
                    Id = 2,
                    Name = "User1",
                    Email = "user1@example.com",
                    PasswordHash = "hashedpassword2",
                    PhoneNumber = "0987654321",
                    Role = UserRole.User
                }
            );

            modelBuilder.Entity<Device>().HasData(
                new Device
                {
                    Id = 1,
                    Type = "Laptop",
                    Brand = "Dell",
                    Model = "XPS 15",
                    SerialNumber = "SN123456",
                    UserId = 2
                },
                new Device
                {
                    Id = 2,
                    Type = "Smartphone",
                    Brand = "Samsung",
                    Model = "Galaxy S21",
                    SerialNumber = "SN654321",
                    UserId = 1
                }
            );

            modelBuilder.Entity<RepairRequest>().HasData(
                new RepairRequest
                {
                    Id = 1,
                    Description = "Screen not working",
                    Status = RepairStatus.Completed,
                    DeviceId = 1,
                    UserId = 1
                },
                new RepairRequest
                {
                    Id = 2,
                    Description = "Battery draining fast",
                    Status = RepairStatus.InProgress,
                    DeviceId = 2,
                    UserId = 2
                }
            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    Text = "Checked screen, needs replacement",
                    RepairRequestId = 1,
                    UserId = 1
                },
                new Comment
                {
                    Id = 2,
                    Text = "Battery replaced, testing now",
                    RepairRequestId = 2,
                    UserId = 2
                }
            );
        }
    }
}
