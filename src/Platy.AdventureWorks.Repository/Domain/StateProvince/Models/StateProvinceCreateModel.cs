namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class StateProvinceCreateModel
  : IEntityCreateModel
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
  ///   Gets or sets the property value for 'StateProvinceCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'StateProvinceCode'.
  /// </value>
  public string StateProvinceCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CountryRegionCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'CountryRegionCode'.
  /// </value>
  public string CountryRegionCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'IsOnlyStateProvinceFlag'.
  /// </summary>
  /// <value>
  ///   The property value for 'IsOnlyStateProvinceFlag'.
  /// </value>
  public bool IsOnlyStateProvinceFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'TerritoryId'.
  /// </summary>
  /// <value>
  ///   The property value for 'TerritoryId'.
  /// </value>
  public int TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Rowguid'.
  /// </summary>
  /// <value>
  ///   The property value for 'Rowguid'.
  /// </value>
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
