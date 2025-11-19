using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'CountryRegion'.
/// </summary>
[Table("CountryRegion", Schema = "Person")]
public class CountryRegion
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CountryRegion" /> class.
  /// </summary>
  public CountryRegion()
  {
    #region Generated Constructor

    CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
    SalesTerritories = new HashSet<SalesTerritory>();
    StateProvinces = new HashSet<StateProvince>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'CountryRegionCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CountryRegionCode'.
  /// </value>
  [Key]
  [Column("CountryRegionCode", TypeName = "nvarchar(3)")]
  public string CountryRegionCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

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
  ///   Gets or sets the navigation collection for entity <see cref="CountryRegionCurrency" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="CountryRegionCurrency" />.
  /// </value>
  public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesTerritory" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesTerritory" />.
  /// </value>
  public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="StateProvince" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="StateProvince" />.
  /// </value>
  public virtual ICollection<StateProvince> StateProvinces { get; set; }

  #endregion
}
