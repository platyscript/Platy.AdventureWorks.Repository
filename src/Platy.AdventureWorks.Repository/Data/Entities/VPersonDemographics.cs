using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vPersonDemographics'.
/// </summary>
[Table("vPersonDemographics", Schema = "Sales")]
public class VPersonDemographics
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VPersonDemographics" /> class.
  /// </summary>
  public VPersonDemographics()
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
  ///   Gets or sets the property value representing column 'TotalPurchaseYTD'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TotalPurchaseYTD'.
  /// </value>
  [Column("TotalPurchaseYTD", TypeName = "money")]
  public decimal? TotalPurchaseYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'DateFirstPurchase'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'DateFirstPurchase'.
  /// </value>
  [Column("DateFirstPurchase", TypeName = "datetime")]
  public DateTime? DateFirstPurchase { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'BirthDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BirthDate'.
  /// </value>
  [Column("BirthDate", TypeName = "datetime")]
  public DateTime? BirthDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'MaritalStatus'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MaritalStatus'.
  /// </value>
  [Column("MaritalStatus", TypeName = "nvarchar(1)")]
  public string? MaritalStatus { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'YearlyIncome'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'YearlyIncome'.
  /// </value>
  [Column("YearlyIncome", TypeName = "nvarchar(30)")]
  public string? YearlyIncome { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Gender'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Gender'.
  /// </value>
  [Column("Gender", TypeName = "nvarchar(1)")]
  public string? Gender { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TotalChildren'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TotalChildren'.
  /// </value>
  [Column("TotalChildren", TypeName = "int")]
  public int? TotalChildren { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'NumberChildrenAtHome'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'NumberChildrenAtHome'.
  /// </value>
  [Column("NumberChildrenAtHome", TypeName = "int")]
  public int? NumberChildrenAtHome { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Education'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Education'.
  /// </value>
  [Column("Education", TypeName = "nvarchar(30)")]
  public string? Education { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Occupation'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Occupation'.
  /// </value>
  [Column("Occupation", TypeName = "nvarchar(30)")]
  public string? Occupation { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'HomeOwnerFlag'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'HomeOwnerFlag'.
  /// </value>
  [Column("HomeOwnerFlag", TypeName = "bit")]
  public bool? HomeOwnerFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'NumberCarsOwned'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'NumberCarsOwned'.
  /// </value>
  [Column("NumberCarsOwned", TypeName = "int")]
  public int? NumberCarsOwned { get; set; }

  #endregion
}
