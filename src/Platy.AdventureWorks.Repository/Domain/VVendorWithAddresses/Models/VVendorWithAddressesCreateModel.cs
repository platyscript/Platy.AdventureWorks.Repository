namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VVendorWithAddressesCreateModel
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
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'AddressType'.
  /// </summary>
  /// <value>
  ///   The property value for 'AddressType'.
  /// </value>
  public string AddressType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'AddressLine1'.
  /// </summary>
  /// <value>
  ///   The property value for 'AddressLine1'.
  /// </value>
  public string AddressLine1 { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'AddressLine2'.
  /// </summary>
  /// <value>
  ///   The property value for 'AddressLine2'.
  /// </value>
  public string? AddressLine2 { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'City'.
  /// </summary>
  /// <value>
  ///   The property value for 'City'.
  /// </value>
  public string City { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'StateProvinceName'.
  /// </summary>
  /// <value>
  ///   The property value for 'StateProvinceName'.
  /// </value>
  public string StateProvinceName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'PostalCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'PostalCode'.
  /// </value>
  public string PostalCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CountryRegionName'.
  /// </summary>
  /// <value>
  ///   The property value for 'CountryRegionName'.
  /// </value>
  public string CountryRegionName { get; set; } = null!;

  #endregion
}
