﻿using RequestSystem.DAL.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; } = null!;

    public int RepairRequestId { get; set; }
    public RepairRequest RepairRequest { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;
}
