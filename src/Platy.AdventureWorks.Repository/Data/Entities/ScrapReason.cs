using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'ScrapReason'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("ScrapReason", Schema = "Production")]
public partial class ScrapReason
    : HasDomainEventsBase, IIdentity<short>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScrapReason"/> class.
    /// </summary>
    public ScrapReason()
    {
        #region Generated Constructor
        WorkOrders = new HashSet<WorkOrder>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ScrapReasonID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ScrapReasonID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ScrapReasonID", TypeName = "smallint")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public short Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name", TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

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
    /// Gets or sets the navigation collection for entity <see cref="WorkOrder" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="WorkOrder" />.
    /// </value>
    public virtual ICollection<WorkOrder> WorkOrders { get; set; }

    #endregion

}
