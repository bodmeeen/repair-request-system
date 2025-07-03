namespace RequestSystem.DAL.Entities
{
    public class Device
    {
        public int Id { get; set; }

        public string Type { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;

        public int UserId { get; set; }
        public User Owner { get; set; } = null!;

        public ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();
    }
}
