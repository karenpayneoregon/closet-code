namespace ShadowProperties.Interfaces;

public interface ISoftDelete
{
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public void Undo()
    {
        IsDeleted = false;
        DeletedAt = null;
    }
}