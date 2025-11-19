namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VSalesPersonSalesByFiscalYearsReadModel
  : IEntityReadModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'SalesPersonId'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesPersonId'.
  /// </value>
  public int? SalesPersonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'FullName'.
  /// </summary>
  /// <value>
  ///   The property value for 'FullName'.
  /// </value>
  public string? FullName { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'JobTitle'.
  /// </summary>
  /// <value>
  ///   The property value for 'JobTitle'.
  /// </value>
  public string JobTitle { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'SalesTerritory'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesTerritory'.
  /// </value>
  public string SalesTerritory { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Number2002'.
  /// </summary>
  /// <value>
  ///   The property value for 'Number2002'.
  /// </value>
  public decimal? Number2002 { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Number2003'.
  /// </summary>
  /// <value>
  ///   The property value for 'Number2003'.
  /// </value>
  public decimal? Number2003 { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Number2004'.
  /// </summary>
  /// <value>
  ///   The property value for 'Number2004'.
  /// </value>
  public decimal? Number2004 { get; set; }

  #endregion
}
