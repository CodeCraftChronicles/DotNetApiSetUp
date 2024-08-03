
namespace CleanArchi.Domain.Primitives;
public interface IAuditableEntity : IEntity<Guid>
{
    DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    DateTime? LastUpdatedOn { get; set; }
    public string? LastUpdatedBy { get; set; }
}
