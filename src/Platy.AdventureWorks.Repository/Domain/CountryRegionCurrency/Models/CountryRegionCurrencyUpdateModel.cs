namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class CountryRegionCurrencyUpdateModel
  : IEntityUpdateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'CountryRegionCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'CountryRegionCode'.
  /// </value>
  public string CountryRegionCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CurrencyCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'CurrencyCode'.
  /// </value>
  public string CurrencyCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
