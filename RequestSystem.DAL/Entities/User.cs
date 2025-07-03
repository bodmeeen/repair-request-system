namespace RequestSystem.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!; 

        public string PasswordHash { get; set; } = null!;

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public UserRole Role { get; set; }

        public ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();
        public ICollection<Device> Devices { get; set; } = new List<Device>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();


    }
}
