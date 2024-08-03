namespace CleanArchi.Domain.Primitives;

public interface IEntity<T> 
{
    T Id { get; set; }
}