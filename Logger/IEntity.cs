namespace Logger;
public interface IEntity
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public string ToString();

    public bool Equals(Entity other);

    public int GetHashCode();
}