namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SalesOrderDetailCreateModel
  : IEntityCreateModel
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
  ///   Gets or sets the property value for 'Id'.
  /// </summary>
  /// <value>
  ///   The property value for 'Id'.
  /// </value>
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CarrierTrackingNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'CarrierTrackingNumber'.
  /// </value>
  public string? CarrierTrackingNumber { get; set; }

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
  ///   Gets or sets the property value for 'SpecialOfferId'.
  /// </summary>
  /// <value>
  ///   The property value for 'SpecialOfferId'.
  /// </value>
  public int SpecialOfferId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'UnitPrice'.
  /// </summary>
  /// <value>
  ///   The property value for 'UnitPrice'.
  /// </value>
  public decimal UnitPrice { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'UnitPriceDiscount'.
  /// </summary>
  /// <value>
  ///   The property value for 'UnitPriceDiscount'.
  /// </value>
  public decimal UnitPriceDiscount { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LineTotal'.
  /// </summary>
  /// <value>
  ///   The property value for 'LineTotal'.
  /// </value>
  public decimal LineTotal { get; set; }

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
