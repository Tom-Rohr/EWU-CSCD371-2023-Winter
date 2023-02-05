namespace Logger;

public abstract record class Entity : IEntity
{
    public abstract string Name { get; init; }

    public Guid Id { get; init; } = Guid.NewGuid();

    public override abstract string ToString();

    public abstract bool Equals(Entity? other);
    public override abstract int GetHashCode();
}
