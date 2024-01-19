using NUnit.Framework;

namespace MapperlyNullableMinimalRepo;

public class EntityMapperTests
{
    [Test]
    public void ToDto_ShouldMapEntityToDto()
    {
        // Arrange
        var entity = Entity.Create(1, new InnerRecord("SomeValue"));

        // Act
        var dto = EntityMapper.ToDto(entity);

        // Assert
        Assert.That(dto, Is.Not.Null);
        Assert.That(entity.Id, Is.EqualTo(1));
        Assert.That(entity.InnerRecord.SomeString, Is.EqualTo("SomeValue"));
    }
}