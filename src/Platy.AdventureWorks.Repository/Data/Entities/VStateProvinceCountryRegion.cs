using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vStateProvinceCountryRegion'.
/// </summary>
[Table("vStateProvinceCountryRegion", Schema = "Person")]
public class VStateProvinceCountryRegion
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VStateProvinceCountryRegion" /> class.
  /// </summary>
  public VStateProvinceCountryRegion()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceID'.
  /// </value>
  [Column("StateProvinceID", TypeName = "int")]
  public int StateProvinceId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceCode'.
  /// </value>
  [Column("StateProvinceCode", TypeName = "nchar(3)")]
  public string StateProvinceCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'IsOnlyStateProvinceFlag'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'IsOnlyStateProvinceFlag'.
  /// </value>
  [Column("IsOnlyStateProvinceFlag", TypeName = "bit")]
  public bool IsOnlyStateProvinceFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceName'.
  /// </value>
  [Column("StateProvinceName", TypeName = "nvarchar(50)")]
  public string StateProvinceName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'TerritoryID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TerritoryID'.
  /// </value>
  [Column("TerritoryID", TypeName = "int")]
  public int TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CountryRegionCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CountryRegionCode'.
  /// </value>
  [Column("CountryRegionCode", TypeName = "nvarchar(3)")]
  public string CountryRegionCode { get; set; } = null!;

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
