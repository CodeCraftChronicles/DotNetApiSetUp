using CleanArchi.Domain.Entities.Primitives;
using CleanArchi.Domain.Primitives;

namespace CleanArchi.Domain.Entities;

public class Personne : AuditableEntity
{
    public required string Name { get; set; }
    public required string FirstName { get; set; }
}
