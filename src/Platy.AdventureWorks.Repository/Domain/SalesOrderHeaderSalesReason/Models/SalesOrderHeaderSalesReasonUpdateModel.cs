namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SalesOrderHeaderSalesReasonUpdateModel
  : IEntityUpdateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'SalesOrderId'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesOrderId'.
  /// </value>
  public int SalesOrderId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesReasonId'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesReasonId'.
  /// </value>
  public int SalesReasonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
