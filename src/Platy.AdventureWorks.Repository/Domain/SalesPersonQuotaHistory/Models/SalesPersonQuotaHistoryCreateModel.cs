namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SalesPersonQuotaHistoryCreateModel
  : IEntityCreateModel
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
  ///   Gets or sets the property value for 'QuotaDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'QuotaDate'.
  /// </value>
  public DateTime QuotaDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesQuota'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesQuota'.
  /// </value>
  public decimal SalesQuota { get; set; }

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
