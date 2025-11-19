using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vEmployeeDepartment'.
/// </summary>
[Table("vEmployeeDepartment", Schema = "HumanResources")]
public class VEmployeeDepartment
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VEmployeeDepartment" /> class.
  /// </summary>
  public VEmployeeDepartment()
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
  ///   Gets or sets the property value representing column 'Title'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Title'.
  /// </value>
  [Column("Title", TypeName = "nvarchar(8)")]
  public string? Title { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'FirstName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'FirstName'.
  /// </value>
  [Column("FirstName", TypeName = "nvarchar(50)")]
  public string FirstName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'MiddleName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MiddleName'.
  /// </value>
  [Column("MiddleName", TypeName = "nvarchar(50)")]
  public string? MiddleName { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LastName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LastName'.
  /// </value>
  [Column("LastName", TypeName = "nvarchar(50)")]
  public string LastName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Suffix'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Suffix'.
  /// </value>
  [Column("Suffix", TypeName = "nvarchar(10)")]
  public string? Suffix { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'JobTitle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'JobTitle'.
  /// </value>
  [Column("JobTitle", TypeName = "nvarchar(50)")]
  public string JobTitle { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Department'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Department'.
  /// </value>
  [Column("Department", TypeName = "nvarchar(50)")]
  public string Department { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'GroupName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'GroupName'.
  /// </value>
  [Column("GroupName", TypeName = "nvarchar(50)")]
  public string GroupName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StartDate'.
  /// </value>
  [Column("StartDate", TypeName = "date")]
  public DateOnly StartDate { get; set; }

  #endregion
}
