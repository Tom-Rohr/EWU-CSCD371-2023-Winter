namespace Logger;
//Implemented both members of IEntity implicitly because it makes sense for both to be apart of the Entity base class.
public abstract record class Entity : IEntity
{
    public abstract string Name { get; init; }

    public Guid Id { get; init; } = Guid.NewGuid();
}