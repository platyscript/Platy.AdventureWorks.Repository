using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vSalesPersonSalesByFiscalYears'.
/// </summary>
[Table("vSalesPersonSalesByFiscalYears", Schema = "Sales")]
public class VSalesPersonSalesByFiscalYears
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VSalesPersonSalesByFiscalYears" /> class.
  /// </summary>
  public VSalesPersonSalesByFiscalYears()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesPersonID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesPersonID'.
  /// </value>
  [Column("SalesPersonID", TypeName = "int")]
  public int? SalesPersonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'FullName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'FullName'.
  /// </value>
  [Column("FullName", TypeName = "nvarchar(152)")]
  public string? FullName { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'JobTitle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'JobTitle'.
  /// </value>
  [Column("JobTitle", TypeName = "nvarchar(50)")]
  public string JobTitle { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesTerritory'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesTerritory'.
  /// </value>
  [Column("SalesTerritory", TypeName = "nvarchar(50)")]
  public string SalesTerritory { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column '2002'.
  /// </summary>
  /// <value>
  ///   The property value representing column '2002'.
  /// </value>
  [Column("2002", TypeName = "money")]
  public decimal? Number2002 { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column '2003'.
  /// </summary>
  /// <value>
  ///   The property value representing column '2003'.
  /// </value>
  [Column("2003", TypeName = "money")]
  public decimal? Number2003 { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column '2004'.
  /// </summary>
  /// <value>
  ///   The property value representing column '2004'.
  /// </value>
  [Column("2004", TypeName = "money")]
  public decimal? Number2004 { get; set; }

  #endregion
}
