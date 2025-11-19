namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VendorUpdateModel
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
  ///   Gets or sets the property value for 'AccountNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'AccountNumber'.
  /// </value>
  public string AccountNumber { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CreditRating'.
  /// </summary>
  /// <value>
  ///   The property value for 'CreditRating'.
  /// </value>
  public byte CreditRating { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'PreferredVendorStatus'.
  /// </summary>
  /// <value>
  ///   The property value for 'PreferredVendorStatus'.
  /// </value>
  public bool PreferredVendorStatus { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ActiveFlag'.
  /// </summary>
  /// <value>
  ///   The property value for 'ActiveFlag'.
  /// </value>
  public bool ActiveFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'PurchasingWebServiceURL'.
  /// </summary>
  /// <value>
  ///   The property value for 'PurchasingWebServiceURL'.
  /// </value>
  public string? PurchasingWebServiceURL { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
