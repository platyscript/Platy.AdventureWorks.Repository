namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SalesOrderHeaderCreateModel
  : IEntityCreateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'Id'.
  /// </summary>
  /// <value>
  ///   The property value for 'Id'.
  /// </value>
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'RevisionNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'RevisionNumber'.
  /// </value>
  public byte RevisionNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'OrderDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'OrderDate'.
  /// </value>
  public DateTime OrderDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'DueDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'DueDate'.
  /// </value>
  public DateTime DueDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ShipDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ShipDate'.
  /// </value>
  public DateTime? ShipDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Status'.
  /// </summary>
  /// <value>
  ///   The property value for 'Status'.
  /// </value>
  public byte Status { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'OnlineOrderFlag'.
  /// </summary>
  /// <value>
  ///   The property value for 'OnlineOrderFlag'.
  /// </value>
  public bool OnlineOrderFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesOrderNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesOrderNumber'.
  /// </value>
  public string SalesOrderNumber { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'PurchaseOrderNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'PurchaseOrderNumber'.
  /// </value>
  public string? PurchaseOrderNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'AccountNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'AccountNumber'.
  /// </value>
  public string? AccountNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CustomerId'.
  /// </summary>
  /// <value>
  ///   The property value for 'CustomerId'.
  /// </value>
  public int CustomerId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesPersonId'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesPersonId'.
  /// </value>
  public int? SalesPersonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TerritoryId'.
  /// </summary>
  /// <value>
  ///   The property value for 'TerritoryId'.
  /// </value>
  public int? TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'BillToAddressId'.
  /// </summary>
  /// <value>
  ///   The property value for 'BillToAddressId'.
  /// </value>
  public int BillToAddressId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ShipToAddressId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ShipToAddressId'.
  /// </value>
  public int ShipToAddressId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ShipMethodId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ShipMethodId'.
  /// </value>
  public int ShipMethodId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CreditCardId'.
  /// </summary>
  /// <value>
  ///   The property value for 'CreditCardId'.
  /// </value>
  public int? CreditCardId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CreditCardApprovalCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'CreditCardApprovalCode'.
  /// </value>
  public string? CreditCardApprovalCode { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CurrencyRateId'.
  /// </summary>
  /// <value>
  ///   The property value for 'CurrencyRateId'.
  /// </value>
  public int? CurrencyRateId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SubTotal'.
  /// </summary>
  /// <value>
  ///   The property value for 'SubTotal'.
  /// </value>
  public decimal SubTotal { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TaxAmt'.
  /// </summary>
  /// <value>
  ///   The property value for 'TaxAmt'.
  /// </value>
  public decimal TaxAmt { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Freight'.
  /// </summary>
  /// <value>
  ///   The property value for 'Freight'.
  /// </value>
  public decimal Freight { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TotalDue'.
  /// </summary>
  /// <value>
  ///   The property value for 'TotalDue'.
  /// </value>
  public decimal TotalDue { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Comment'.
  /// </summary>
  /// <value>
  ///   The property value for 'Comment'.
  /// </value>
  public string? Comment { get; set; }

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
