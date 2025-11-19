using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vVendorWithAddresses'.
/// </summary>
[Table("vVendorWithAddresses", Schema = "Purchasing")]
public class VVendorWithAddresses
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VVendorWithAddresses" /> class.
  /// </summary>
  public VVendorWithAddresses()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Column("BusinessEntityID", TypeName = "int")]
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'AddressType'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AddressType'.
  /// </value>
  [Column("AddressType", TypeName = "nvarchar(50)")]
  public string AddressType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'AddressLine1'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AddressLine1'.
  /// </value>
  [Column("AddressLine1", TypeName = "nvarchar(60)")]
  public string AddressLine1 { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'AddressLine2'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AddressLine2'.
  /// </value>
  [Column("AddressLine2", TypeName = "nvarchar(60)")]
  public string? AddressLine2 { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'City'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'City'.
  /// </value>
  [Column("City", TypeName = "nvarchar(30)")]
  public string City { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceName'.
  /// </value>
  [Column("StateProvinceName", TypeName = "nvarchar(50)")]
  public string StateProvinceName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'PostalCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PostalCode'.
  /// </value>
  [Column("PostalCode", TypeName = "nvarchar(15)")]
  public string PostalCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'CountryRegionName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CountryRegionName'.
  /// </value>
  [Column("CountryRegionName", TypeName = "nvarchar(50)")]
  public string CountryRegionName { get; set; } = null!;

  #endregion
}
