namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class LocationCreateModel
  : IEntityCreateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'Id'.
  /// </summary>
  /// <value>
  ///   The property value for 'Id'.
  /// </value>
  public short Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CostRate'.
  /// </summary>
  /// <value>
  ///   The property value for 'CostRate'.
  /// </value>
  public decimal CostRate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Availability'.
  /// </summary>
  /// <value>
  ///   The property value for 'Availability'.
  /// </value>
  public decimal Availability { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
