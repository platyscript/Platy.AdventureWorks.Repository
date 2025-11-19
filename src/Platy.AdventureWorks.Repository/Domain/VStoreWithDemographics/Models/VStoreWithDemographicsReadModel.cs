namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VStoreWithDemographicsReadModel
  : IEntityReadModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'BusinessEntityId'.
  /// </summary>
  /// <value>
  ///   The property value for 'BusinessEntityId'.
  /// </value>
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'AnnualSales'.
  /// </summary>
  /// <value>
  ///   The property value for 'AnnualSales'.
  /// </value>
  public decimal? AnnualSales { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'AnnualRevenue'.
  /// </summary>
  /// <value>
  ///   The property value for 'AnnualRevenue'.
  /// </value>
  public decimal? AnnualRevenue { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'BankName'.
  /// </summary>
  /// <value>
  ///   The property value for 'BankName'.
  /// </value>
  public string? BankName { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'BusinessType'.
  /// </summary>
  /// <value>
  ///   The property value for 'BusinessType'.
  /// </value>
  public string? BusinessType { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'YearOpened'.
  /// </summary>
  /// <value>
  ///   The property value for 'YearOpened'.
  /// </value>
  public int? YearOpened { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Specialty'.
  /// </summary>
  /// <value>
  ///   The property value for 'Specialty'.
  /// </value>
  public string? Specialty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SquareFeet'.
  /// </summary>
  /// <value>
  ///   The property value for 'SquareFeet'.
  /// </value>
  public int? SquareFeet { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Brands'.
  /// </summary>
  /// <value>
  ///   The property value for 'Brands'.
  /// </value>
  public string? Brands { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Internet'.
  /// </summary>
  /// <value>
  ///   The property value for 'Internet'.
  /// </value>
  public string? Internet { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'NumberEmployees'.
  /// </summary>
  /// <value>
  ///   The property value for 'NumberEmployees'.
  /// </value>
  public int? NumberEmployees { get; set; }

  #endregion
}
