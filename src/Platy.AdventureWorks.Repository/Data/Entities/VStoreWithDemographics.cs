using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vStoreWithDemographics'.
/// </summary>
[Table("vStoreWithDemographics", Schema = "Sales")]
public class VStoreWithDemographics
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VStoreWithDemographics" /> class.
  /// </summary>
  public VStoreWithDemographics()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Column("BusinessEntityID", TypeName = "int")]
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'AnnualSales'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AnnualSales'.
  /// </value>
  [Column("AnnualSales", TypeName = "money")]
  public decimal? AnnualSales { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'AnnualRevenue'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AnnualRevenue'.
  /// </value>
  [Column("AnnualRevenue", TypeName = "money")]
  public decimal? AnnualRevenue { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'BankName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BankName'.
  /// </value>
  [Column("BankName", TypeName = "nvarchar(50)")]
  public string? BankName { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessType'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessType'.
  /// </value>
  [Column("BusinessType", TypeName = "nvarchar(5)")]
  public string? BusinessType { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'YearOpened'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'YearOpened'.
  /// </value>
  [Column("YearOpened", TypeName = "int")]
  public int? YearOpened { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Specialty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Specialty'.
  /// </value>
  [Column("Specialty", TypeName = "nvarchar(50)")]
  public string? Specialty { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SquareFeet'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SquareFeet'.
  /// </value>
  [Column("SquareFeet", TypeName = "int")]
  public int? SquareFeet { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Brands'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Brands'.
  /// </value>
  [Column("Brands", TypeName = "nvarchar(30)")]
  public string? Brands { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Internet'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Internet'.
  /// </value>
  [Column("Internet", TypeName = "nvarchar(30)")]
  public string? Internet { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'NumberEmployees'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'NumberEmployees'.
  /// </value>
  [Column("NumberEmployees", TypeName = "int")]
  public int? NumberEmployees { get; set; }

  #endregion
}
