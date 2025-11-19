namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class EmployeePayHistoryReadModel
  : IEntityReadModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'BusinessEntityId'.
  /// </summary>
  /// <value>
  ///   The property value for 'BusinessEntityId'.
  /// </value>
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'RateChangeDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'RateChangeDate'.
  /// </value>
  public DateTime RateChangeDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Rate'.
  /// </summary>
  /// <value>
  ///   The property value for 'Rate'.
  /// </value>
  public decimal Rate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'PayFrequency'.
  /// </summary>
  /// <value>
  ///   The property value for 'PayFrequency'.
  /// </value>
  public byte PayFrequency { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
