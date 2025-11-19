using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'JobCandidate'.
/// </summary>
[Table("JobCandidate", Schema = "HumanResources")]
public class JobCandidate
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="JobCandidate" /> class.
  /// </summary>
  public JobCandidate()
  {
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Employee" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Employee" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Employee? Employee { get; set; }

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'JobCandidateID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'JobCandidateID'.
  /// </value>
  [Key]
  [Column("JobCandidateID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Column("BusinessEntityID", TypeName = "int")]
  public int? BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Resume'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Resume'.
  /// </value>
  [Column("Resume", TypeName = "xml")]
  public string? Resume { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ModifiedDate'.
  /// </value>
  [Column("ModifiedDate", TypeName = "datetime")]
  public DateTime ModifiedDate { get; set; }

  #endregion
}
