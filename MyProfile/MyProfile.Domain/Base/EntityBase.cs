namespace MyProfile.Domain;

public abstract class EntityBase
{
    public EntityBase(int? id, DateTime updatedAt, DateTime? deletedAt, DateTime createdAt)
    {
        Id = id;
        UpdatedAt = updatedAt;
        DeletedAt = deletedAt;
    }

    public int? Id { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public DateTime CreatedAt { get; set; }
}
