using qs.geometry.Contracts;

namespace qs.geometry.Tests.Models;

[TestSubject(typeof(Triangle))]
public class TriangleTest
{
    [Fact]
    public void GetArea_OnValidTriangle_ReturnsExpectedValue()
    {
        var sut = new Triangle(3, 4, 5);

        double area = sut.GetArea();

        area.ShouldBe(6, 0.00001d);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 4, 6, false)]
    public void ValidTriangle_IsRightAngled_ReturnsExpectedValue(double a, double b, double c, bool expected)
    {
        ITriangle sut = new Triangle(a, b, c);

        var actual = sut.IsRightTriangle();

        actual.ShouldBe(expected);
    }

    [Fact]
    public void Triangle_InvalidSides_ThrowsException()
    {
        Should.Throw<InvalidShapeException>(() => new Triangle(3, 4, 12));
    }

    [Fact]
    public void deletethis()
    {
        IShape shape1 = new Circle(5); //~78.53981
        double area1 = shape1.GetArea();
        area1.ShouldBe(78.53981d, 0.00001d);

        ITriangle shape2 = new Triangle(3, 4, 5);
        double area2 = shape2.GetArea(); //6
        area2.ShouldBe(6);
        bool isRight = shape2.IsRightTriangle();
        isRight.ShouldBeTrue();
    }
}