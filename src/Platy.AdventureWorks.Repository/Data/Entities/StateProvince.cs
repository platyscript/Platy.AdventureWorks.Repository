using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'StateProvince'.
/// </summary>
[Table("StateProvince", Schema = "Person")]
public class StateProvince
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="StateProvince" /> class.
  /// </summary>
  public StateProvince()
  {
    #region Generated Constructor

    Addresses = new HashSet<Address>();
    SalesTaxRates = new HashSet<SalesTaxRate>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceID'.
  /// </value>
  [Key]
  [Column("StateProvinceID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceCode'.
  /// </value>
  [Column("StateProvinceCode", TypeName = "nchar(3)")]
  public string StateProvinceCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'CountryRegionCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CountryRegionCode'.
  /// </value>
  [Column("CountryRegionCode", TypeName = "nvarchar(3)")]
  public string CountryRegionCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'IsOnlyStateProvinceFlag'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'IsOnlyStateProvinceFlag'.
  /// </value>
  [Column("IsOnlyStateProvinceFlag", TypeName = "bit")]
  public bool IsOnlyStateProvinceFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'TerritoryID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TerritoryID'.
  /// </value>
  [Column("TerritoryID", TypeName = "int")]
  public int TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'rowguid'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'rowguid'.
  /// </value>
  [Column("rowguid", TypeName = "uniqueidentifier")]
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ModifiedDate'.
  /// </value>
  [Column("ModifiedDate", TypeName = "datetime")]
  public DateTime ModifiedDate { get; set; }

  #endregion

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="Address" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="Address" />.
  /// </value>
  public virtual ICollection<Address> Addresses { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="CountryRegion" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="CountryRegion" />.
  /// </value>
  /// <seealso cref="CountryRegionCode" />
  public virtual CountryRegion CountryRegion { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesTaxRate" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesTaxRate" />.
  /// </value>
  public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesTerritory" />.
  /// </value>
  /// <seealso cref="TerritoryId" />
  public virtual SalesTerritory SalesTerritory { get; set; } = null!;

  #endregion
}
