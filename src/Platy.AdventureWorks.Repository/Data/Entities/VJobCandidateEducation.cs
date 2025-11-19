using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vJobCandidateEducation'.
/// </summary>
[Table("vJobCandidateEducation", Schema = "HumanResources")]
public class VJobCandidateEducation
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateEducation" /> class.
  /// </summary>
  public VJobCandidateEducation()
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
  ///   Gets or sets the property value representing column 'Edu.Level'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.Level'.
  /// </value>
  [Column("Edu.Level", TypeName = "nvarchar(max)")]
  public string? EduLevel { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.StartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.StartDate'.
  /// </value>
  [Column("Edu.StartDate", TypeName = "datetime")]
  public DateTime? EduStartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.EndDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.EndDate'.
  /// </value>
  [Column("Edu.EndDate", TypeName = "datetime")]
  public DateTime? EduEndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.Degree'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.Degree'.
  /// </value>
  [Column("Edu.Degree", TypeName = "nvarchar(50)")]
  public string? EduDegree { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.Major'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.Major'.
  /// </value>
  [Column("Edu.Major", TypeName = "nvarchar(50)")]
  public string? EduMajor { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.Minor'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.Minor'.
  /// </value>
  [Column("Edu.Minor", TypeName = "nvarchar(50)")]
  public string? EduMinor { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.GPA'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.GPA'.
  /// </value>
  [Column("Edu.GPA", TypeName = "nvarchar(5)")]
  public string? EduGPA { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.GPAScale'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.GPAScale'.
  /// </value>
  [Column("Edu.GPAScale", TypeName = "nvarchar(5)")]
  public string? EduGPAScale { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.School'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.School'.
  /// </value>
  [Column("Edu.School", TypeName = "nvarchar(100)")]
  public string? EduSchool { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.Loc.CountryRegion'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.Loc.CountryRegion'.
  /// </value>
  [Column("Edu.Loc.CountryRegion", TypeName = "nvarchar(100)")]
  public string? EduLocCountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.Loc.State'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.Loc.State'.
  /// </value>
  [Column("Edu.Loc.State", TypeName = "nvarchar(100)")]
  public string? EduLocState { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Edu.Loc.City'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Edu.Loc.City'.
  /// </value>
  [Column("Edu.Loc.City", TypeName = "nvarchar(100)")]
  public string? EduLocCity { get; set; }

  #endregion
}
