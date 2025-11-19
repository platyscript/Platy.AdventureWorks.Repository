namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class PurchaseOrderHeaderReadModel
  : IEntityReadModel
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
  ///   Gets or sets the property value for 'Status'.
  /// </summary>
  /// <value>
  ///   The property value for 'Status'.
  /// </value>
  public byte Status { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EmployeeId'.
  /// </summary>
  /// <value>
  ///   The property value for 'EmployeeId'.
  /// </value>
  public int EmployeeId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'VendorId'.
  /// </summary>
  /// <value>
  ///   The property value for 'VendorId'.
  /// </value>
  public int VendorId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ShipMethodId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ShipMethodId'.
  /// </value>
  public int ShipMethodId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'OrderDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'OrderDate'.
  /// </value>
  public DateTime OrderDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ShipDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ShipDate'.
  /// </value>
  public DateTime? ShipDate { get; set; }

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
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
