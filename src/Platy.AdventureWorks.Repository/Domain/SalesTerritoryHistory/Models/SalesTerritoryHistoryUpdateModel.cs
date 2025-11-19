namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SalesTerritoryHistoryUpdateModel
  : IEntityUpdateModel
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
  ///   Gets or sets the property value for 'TerritoryId'.
  /// </summary>
  /// <value>
  ///   The property value for 'TerritoryId'.
  /// </value>
  public int TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'StartDate'.
  /// </value>
  public DateTime StartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EndDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'EndDate'.
  /// </value>
  public DateTime? EndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Rowguid'.
  /// </summary>
  /// <value>
  ///   The property value for 'Rowguid'.
  /// </value>
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
