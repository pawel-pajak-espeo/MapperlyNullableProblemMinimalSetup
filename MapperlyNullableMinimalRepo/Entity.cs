using Riok.Mapperly.Abstractions;

namespace MapperlyNullableMinimalRepo;

public record InnerRecord(string SomeString);

public class Entity
{
    private Entity(int id, InnerRecord innerRecord)
    {
        Id = id;
        InnerRecord = innerRecord;
    }

    public int Id { get; }
    public InnerRecord InnerRecord { get; }

    public static Entity Create(int id, InnerRecord innerRecord)
    {
        return new Entity(id, innerRecord);
    }
}

public record Dto(int Id, InnerRecord InnerRecord);

[Mapper]
public static partial class EntityMapper
{
    public static partial Dto ToDto(this Entity spool);
    public static partial IQueryable<Dto> ProjectToDto(this IQueryable<Entity> form);
}