using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'CountryRegionCurrency'.
/// </summary>
[Table("CountryRegionCurrency", Schema = "Sales")]
public class CountryRegionCurrency
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CountryRegionCurrency" /> class.
  /// </summary>
  public CountryRegionCurrency()
  {
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
  ///   Gets or sets the property value representing column 'CurrencyCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CurrencyCode'.
  /// </value>
  [Key]
  [Column("CurrencyCode", TypeName = "nchar(3)")]
  public string CurrencyCode { get; set; } = null!;

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
  ///   Gets or sets the navigation property for entity <see cref="CountryRegion" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="CountryRegion" />.
  /// </value>
  /// <seealso cref="CountryRegionCode" />
  public virtual CountryRegion CountryRegion { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Currency" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Currency" />.
  /// </value>
  /// <seealso cref="CurrencyCode" />
  public virtual Currency Currency { get; set; } = null!;

  #endregion
}
