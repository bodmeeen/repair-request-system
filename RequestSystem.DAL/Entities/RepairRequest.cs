namespace RequestSystem.DAL.Entities
{
    public class RepairRequest
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public RepairStatus Status { get; set; }

        public int DeviceId { get; set; }
        public Device Device { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
