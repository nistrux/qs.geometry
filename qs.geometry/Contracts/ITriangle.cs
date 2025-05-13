namespace qs.geometry.Contracts;

/// <summary>
/// Defines the interface for a triangle geometric shape. This interface exposes methods related to triangles,
/// including checking if it's a right-angled triangle (via an implementing class).
/// </summary>
public interface ITriangle : IShape
{
    /// <summary>
    /// Checks whether this triangle is a right-angled triangle.
    /// <see href="https://en.wikipedia.org/wiki/Right_triangle"></see>
    /// </summary>
    /// <returns>True if this triangle is right-angled, false otherwise.</returns>
    bool IsRightTriangle();
}