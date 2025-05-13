using qs.geometry.Contracts;

namespace qs.geometry.Models;

/// <summary>
/// Abstract base class implementing common interface for geometric shapes with area calculations.
/// </summary>
public abstract class BaseShape : IShape
{
    public abstract double GetArea();
}