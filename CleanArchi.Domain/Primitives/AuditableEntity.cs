using CleanArchi.Application;
using CleanArchi.Domain.Primitives;

using System.Reflection.Metadata;

namespace CleanArchi.Domain.Entities.Primitives;

public abstract class AuditableEntity : IAuditableEntity
{
    public required User User { get; set; }
    public DateTime CreatedOn { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? LastUpdatedOn { get; set; }
    public string? LastUpdatedBy { get; set; }
    public Guid Id { get; set; }
}
