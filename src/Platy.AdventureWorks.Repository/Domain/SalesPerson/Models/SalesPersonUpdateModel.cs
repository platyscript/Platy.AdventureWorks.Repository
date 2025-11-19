namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SalesPersonUpdateModel
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
  public int? TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesQuota'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesQuota'.
  /// </value>
  public decimal? SalesQuota { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Bonus'.
  /// </summary>
  /// <value>
  ///   The property value for 'Bonus'.
  /// </value>
  public decimal Bonus { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CommissionPct'.
  /// </summary>
  /// <value>
  ///   The property value for 'CommissionPct'.
  /// </value>
  public decimal CommissionPct { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesYTD'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesYTD'.
  /// </value>
  public decimal SalesYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesLastYear'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesLastYear'.
  /// </value>
  public decimal SalesLastYear { get; set; }

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
