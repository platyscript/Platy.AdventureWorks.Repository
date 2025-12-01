using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vJobCandidate'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vJobCandidate", Schema = "HumanResources")]
public partial class VJobCandidate
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidate"/> class.
    /// </summary>
    public VJobCandidate()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'JobCandidateID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'JobCandidateID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("JobCandidateID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'BusinessEntityID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BusinessEntityID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("BusinessEntityID", TypeName = "int")]
    public int? BusinessEntityId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name.Prefix'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name.Prefix'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name.Prefix", TypeName = "nvarchar(30)")]
    public string? NamePrefix { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name.First'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name.First'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name.First", TypeName = "nvarchar(30)")]
    public string? NameFirst { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name.Middle'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name.Middle'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name.Middle", TypeName = "nvarchar(30)")]
    public string? NameMiddle { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name.Last'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name.Last'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name.Last", TypeName = "nvarchar(30)")]
    public string? NameLast { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name.Suffix'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name.Suffix'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name.Suffix", TypeName = "nvarchar(30)")]
    public string? NameSuffix { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Skills'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Skills'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Skills", TypeName = "nvarchar(max)")]
    public string? Skills { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Addr.Type'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Addr.Type'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Addr.Type", TypeName = "nvarchar(30)")]
    public string? AddrType { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Addr.Loc.CountryRegion'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Addr.Loc.CountryRegion'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Addr.Loc.CountryRegion", TypeName = "nvarchar(100)")]
    public string? AddrLocCountryRegion { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Addr.Loc.State'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Addr.Loc.State'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Addr.Loc.State", TypeName = "nvarchar(100)")]
    public string? AddrLocState { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Addr.Loc.City'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Addr.Loc.City'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Addr.Loc.City", TypeName = "nvarchar(100)")]
    public string? AddrLocCity { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Addr.PostalCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Addr.PostalCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Addr.PostalCode", TypeName = "nvarchar(20)")]
    public string? AddrPostalCode { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EMail'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EMail'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EMail", TypeName = "nvarchar(max)")]
    public string? EMail { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'WebSite'.
    /// </summary>
    /// <value>
    /// The property value representing column 'WebSite'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("WebSite", TypeName = "nvarchar(max)")]
    public string? WebSite { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ModifiedDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ModifiedDate", TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
