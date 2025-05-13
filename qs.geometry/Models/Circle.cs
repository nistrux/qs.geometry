using qs.geometry.Exceptions;

namespace qs.geometry.Models;

/// <summary>
/// Represents a circle shape
/// </summary>
public class Circle : BaseShape
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
    /// </summary>
    /// <param name="radius">The radius of the circle. Must be greater than zero.</param>
    /// <exception cref="InvalidShapeException">
    /// Thrown when the <paramref name="radius"/> is less than or equal to zero.
    /// </exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new InvalidShapeException("Radius must be positive");

        Radius = radius;
    }

    /// <summary>
    /// Radius of a circle
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Calculates the area of a circle based on its radius value.
    /// </summary>
    /// <returns>The computed area as a double.</returns>
    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}