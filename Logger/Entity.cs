namespace Logger;

public abstract record class Entity : IEntity
{
    public abstract string Name { get; init; }

    public Guid Id { get; init; } = Guid.NewGuid();

    public override abstract string ToString();// Does this even do anything if we're implementing on other records? Automatically overriden w/ records

    public abstract bool Equals(Entity? other);
    public override abstract int GetHashCode();
}