using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'JobCandidate'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("JobCandidate", Schema = "HumanResources")]
public partial class JobCandidate
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JobCandidate"/> class.
    /// </summary>
    public JobCandidate()
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
    [System.ComponentModel.DataAnnotations.Key()]
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
    /// Gets or sets the property value representing column 'Resume'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Resume'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Resume", TypeName = "xml")]
    public string? Resume { get; set; }

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
    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Employee" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Employee" />.
    /// </value>
    /// <seealso cref="BusinessEntityId" />
    public virtual Employee? Employee { get; set; }

    #endregion

}
