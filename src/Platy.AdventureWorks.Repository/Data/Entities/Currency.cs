using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Currency'.
/// </summary>
[Table("Currency", Schema = "Sales")]
public class Currency
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Currency" /> class.
  /// </summary>
  public Currency()
  {
    #region Generated Constructor

    CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
    FromCurrencyRates = new HashSet<CurrencyRate>();
    ToCurrencyRates = new HashSet<CurrencyRate>();

    #endregion
  }

  #region Generated Properties

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
  ///   Gets or sets the navigation collection for entity <see cref="CurrencyRate" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="CurrencyRate" />.
  /// </value>
  public virtual ICollection<CurrencyRate> FromCurrencyRates { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="CurrencyRate" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="CurrencyRate" />.
  /// </value>
  public virtual ICollection<CurrencyRate> ToCurrencyRates { get; set; }

  #endregion
}
