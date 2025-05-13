namespace qs.geometry.Tests.Models;

[TestSubject(typeof(Circle))]
public class CircleTest
{
    [Fact]
    public void CircleArea_WithCorrectRadius_ReturnsExpectedValue()
    {
        var sut = new Circle(2);

        double area = sut.GetArea();

        area.ShouldBe(Math.PI * 4, 0.00001d);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-3.14d)]
    public void Constructor_WithIncorrectRadius_ThrowsArgumentException(double radius)
    {
        Should.Throw<InvalidShapeException>(() => new Circle(radius));
    }
}