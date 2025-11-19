namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SalesTerritoryUpdateModel
  : IEntityUpdateModel
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
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CountryRegionCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'CountryRegionCode'.
  /// </value>
  public string CountryRegionCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Group'.
  /// </summary>
  /// <value>
  ///   The property value for 'Group'.
  /// </value>
  public string Group { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'SalesYTD'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesYTD'.
  /// </value>
  public decimal SalesYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesLastYear'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesLastYear'.
  /// </value>
  public decimal SalesLastYear { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CostYTD'.
  /// </summary>
  /// <value>
  ///   The property value for 'CostYTD'.
  /// </value>
  public decimal CostYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CostLastYear'.
  /// </summary>
  /// <value>
  ///   The property value for 'CostLastYear'.
  /// </value>
  public decimal CostLastYear { get; set; }

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
