using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vJobCandidate'.
/// </summary>
[Table("vJobCandidate", Schema = "HumanResources")]
public class VJobCandidate
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidate" /> class.
  /// </summary>
  public VJobCandidate()
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
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Column("BusinessEntityID", TypeName = "int")]
  public int? BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name.Prefix'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name.Prefix'.
  /// </value>
  [Column("Name.Prefix", TypeName = "nvarchar(30)")]
  public string? NamePrefix { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name.First'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name.First'.
  /// </value>
  [Column("Name.First", TypeName = "nvarchar(30)")]
  public string? NameFirst { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name.Middle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name.Middle'.
  /// </value>
  [Column("Name.Middle", TypeName = "nvarchar(30)")]
  public string? NameMiddle { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name.Last'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name.Last'.
  /// </value>
  [Column("Name.Last", TypeName = "nvarchar(30)")]
  public string? NameLast { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name.Suffix'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name.Suffix'.
  /// </value>
  [Column("Name.Suffix", TypeName = "nvarchar(30)")]
  public string? NameSuffix { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Skills'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Skills'.
  /// </value>
  [Column("Skills", TypeName = "nvarchar(max)")]
  public string? Skills { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Addr.Type'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Addr.Type'.
  /// </value>
  [Column("Addr.Type", TypeName = "nvarchar(30)")]
  public string? AddrType { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Addr.Loc.CountryRegion'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Addr.Loc.CountryRegion'.
  /// </value>
  [Column("Addr.Loc.CountryRegion", TypeName = "nvarchar(100)")]
  public string? AddrLocCountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Addr.Loc.State'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Addr.Loc.State'.
  /// </value>
  [Column("Addr.Loc.State", TypeName = "nvarchar(100)")]
  public string? AddrLocState { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Addr.Loc.City'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Addr.Loc.City'.
  /// </value>
  [Column("Addr.Loc.City", TypeName = "nvarchar(100)")]
  public string? AddrLocCity { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Addr.PostalCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Addr.PostalCode'.
  /// </value>
  [Column("Addr.PostalCode", TypeName = "nvarchar(20)")]
  public string? AddrPostalCode { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EMail'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EMail'.
  /// </value>
  [Column("EMail", TypeName = "nvarchar(max)")]
  public string? EMail { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'WebSite'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'WebSite'.
  /// </value>
  [Column("WebSite", TypeName = "nvarchar(max)")]
  public string? WebSite { get; set; }

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
