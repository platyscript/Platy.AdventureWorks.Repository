using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vJobCandidateEmployment'.
/// </summary>
[Table("vJobCandidateEmployment", Schema = "HumanResources")]
public class VJobCandidateEmployment
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateEmployment" /> class.
  /// </summary>
  public VJobCandidateEmployment()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'JobCandidateID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'JobCandidateID'.
  /// </value>
  [Column("JobCandidateID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.StartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.StartDate'.
  /// </value>
  [Column("Emp.StartDate", TypeName = "datetime")]
  public DateTime? EmpStartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.EndDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.EndDate'.
  /// </value>
  [Column("Emp.EndDate", TypeName = "datetime")]
  public DateTime? EmpEndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.OrgName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.OrgName'.
  /// </value>
  [Column("Emp.OrgName", TypeName = "nvarchar(100)")]
  public string? EmpOrgName { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.JobTitle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.JobTitle'.
  /// </value>
  [Column("Emp.JobTitle", TypeName = "nvarchar(100)")]
  public string? EmpJobTitle { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.Responsibility'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.Responsibility'.
  /// </value>
  [Column("Emp.Responsibility", TypeName = "nvarchar(max)")]
  public string? EmpResponsibility { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.FunctionCategory'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.FunctionCategory'.
  /// </value>
  [Column("Emp.FunctionCategory", TypeName = "nvarchar(max)")]
  public string? EmpFunctionCategory { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.IndustryCategory'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.IndustryCategory'.
  /// </value>
  [Column("Emp.IndustryCategory", TypeName = "nvarchar(max)")]
  public string? EmpIndustryCategory { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.Loc.CountryRegion'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.Loc.CountryRegion'.
  /// </value>
  [Column("Emp.Loc.CountryRegion", TypeName = "nvarchar(max)")]
  public string? EmpLocCountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.Loc.State'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.Loc.State'.
  /// </value>
  [Column("Emp.Loc.State", TypeName = "nvarchar(max)")]
  public string? EmpLocState { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Emp.Loc.City'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Emp.Loc.City'.
  /// </value>
  [Column("Emp.Loc.City", TypeName = "nvarchar(max)")]
  public string? EmpLocCity { get; set; }

  #endregion
}
