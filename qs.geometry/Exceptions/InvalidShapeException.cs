namespace qs.geometry.Exceptions;

/// <summary>
/// Represents errors that occur when the parameters provided to create a geometric shape are invalid.
/// </summary>
/// <remarks>
/// This exception is typically thrown from shape constructors when one or more arguments 
/// violate the expected constraints (e.g., negative lengths, non-closing polygons, etc.).
/// </remarks>
public class InvalidShapeException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidShapeException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public InvalidShapeException(string message) : base(message)
    {
    }
}