namespace qs.geometry.Contracts;

/// <summary>
/// Interface defining the common methods for all geometric shapes that have an area.
/// </summary>
public interface IShape
{
    /// Returns the area of the geometric shape implemented by this interface.
    /// The area is a measure of the two-dimensional space enclosed within the boundaries of the shape.
    /// <returns>
    /// A double representing the numerical value of the area.
    /// </returns>
    double GetArea();
}