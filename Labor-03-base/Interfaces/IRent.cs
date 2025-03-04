namespace Labor_03_base.Interfaces;

/// <summary>
/// Defines a rental property with methods to determine cost, check availability, and book the property.
/// </summary>
public interface IRent
{
    // methods
    /// <summary>
    /// Calculates the rental cost for a given number of months for a single occupant.
    /// </summary>
    /// <param name="months">The number of months the property will be rented.</param>
    /// <returns>The total cost of renting the property for the specified duration.</returns>
    int GetCost(int months);

    /// <summary>
    /// Attempts to book the property for a specified number of months.
    /// </summary>
    /// <param name="months">The number of months to book the property for.</param>
    /// <returns>True if the booking was successful, otherwise false.</returns>
    bool Book(int months);

    // properties
    /// <summary>
    /// Gets a value indicating whether the property is currently booked.
    /// </summary>
    bool IsBooked { get; }
}
