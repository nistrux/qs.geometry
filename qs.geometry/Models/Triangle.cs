using qs.geometry.Contracts;
using qs.geometry.Exceptions;

namespace qs.geometry.Models;

/// <summary>
/// Represents a triangle shape with three side lengths A, B, and C.
/// </summary>
public class Triangle : BaseShape, ITriangle
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
    /// </summary>
    /// <param name="a">Length of side A. Must be positive.</param>
    /// <param name="b">Length of side B. Must be positive.</param>
    /// <param name="c">Length of side C. Must be positive.</param>
    /// <exception cref="InvalidShapeException">
    /// Thrown when the side lengths do not satisfy the triangle inequality or are not positive.
    /// </exception>
    public Triangle(double a, double b, double c)
    {
        if (!IsValid(a, b, c))
            throw new InvalidShapeException("Invalid triangle sides.");

        A = a;
        B = b;
        C = c;
    }

    public double A { get; }
    public double B { get; }
    public double C { get; }

    /// <summary>
    /// Checks if this triangle is a right-angled triangle.
    /// A triangle is right-angled if the sum of squares of two sides equals the square of the third side (hypotenuse).
    /// Based on Pythagoras' theorem within a precision tolerance to account for floating-point errors.
    ///</summary>
    /// <returns>True if triangle is right-angled, false otherwise.</returns>
    public bool IsRightTriangle()
    {
        double[] sidesSorted = [A, B, C];
        Array.Sort(sidesSorted);

        double hypotenuseSquared = sidesSorted[2] * sidesSorted[2];
        double legsSquaredSum = sidesSorted[0] * sidesSorted[0] + sidesSorted[1] * sidesSorted[1];

        const double tolerance = 1e-10;

        return Math.Abs(hypotenuseSquared - legsSquaredSum) < tolerance;
    }

    /// <summary>
    /// Calculates the area of a triangle using Heron's formula.
    /// <see href="https://en.wikipedia.org/wiki/Heron%27s_formula">Heron's formula</see>
    /// The area is computed based on the lengths of the three sides:
    /// A, B, and C.
    /// </summary>
    /// <returns>The area of the triangle</returns>
    public override double GetArea()
    {
        double s = 0.5d * (A + B + C);
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    /// <summary>
    /// Checks if the given side lengths (a, b, c) can form a valid triangle based on two conditions:
    /// 1. All sides must be greater than zero
    /// 2. The sum of any two sides must be greater than the third side (triangle inequality theorem)
    /// This method ensures that the provided side lengths satisfy these geometric constraints.
    /// </summary>
    /// <param name="a">Side A</param>
    /// <param name="b">Side B</param>
    /// <param name="c">Side C</param>
    /// <returns>True if the sides form a valid triangle, false otherwise.</returns>
    private static bool IsValid(double a, double b, double c)
    {
        return a > 0 && b > 0 && c > 0 && //each side greater than 0
               a + b > c && a + c > b && b + c > a; //sum of 2 sides > third side
    }
}