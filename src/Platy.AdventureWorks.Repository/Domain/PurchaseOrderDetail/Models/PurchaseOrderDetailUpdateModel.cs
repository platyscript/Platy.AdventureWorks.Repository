namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class PurchaseOrderDetailUpdateModel
  : IEntityUpdateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'PurchaseOrderId'.
  /// </summary>
  /// <value>
  ///   The property value for 'PurchaseOrderId'.
  /// </value>
  public int PurchaseOrderId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Id'.
  /// </summary>
  /// <value>
  ///   The property value for 'Id'.
  /// </value>
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'DueDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'DueDate'.
  /// </value>
  public DateTime DueDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'OrderQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'OrderQty'.
  /// </value>
  public short OrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ProductId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductId'.
  /// </value>
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'UnitPrice'.
  /// </summary>
  /// <value>
  ///   The property value for 'UnitPrice'.
  /// </value>
  public decimal UnitPrice { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LineTotal'.
  /// </summary>
  /// <value>
  ///   The property value for 'LineTotal'.
  /// </value>
  public decimal LineTotal { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ReceivedQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'ReceivedQty'.
  /// </value>
  public decimal ReceivedQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'RejectedQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'RejectedQty'.
  /// </value>
  public decimal RejectedQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'StockedQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'StockedQty'.
  /// </value>
  public decimal StockedQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
