using CleanArchi.Domain.Primitives;

namespace CleanArchi.Domain.Entities.Primitives;

public abstract class AuditableEntity : IAuditableEntity
{
    public DateTime CreatedOn { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? LastUpdatedOn { get; set; }
    public string? LastUpdatedBy { get; set; }
    public Guid Id { get; set; }
}
