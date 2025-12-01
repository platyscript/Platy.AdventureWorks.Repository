using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'SalesReason'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("SalesReason", Schema = "Sales")]
public partial class SalesReason
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesReason"/> class.
    /// </summary>
    public SalesReason()
    {
        #region Generated Constructor
        SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'SalesReasonID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'SalesReasonID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("SalesReasonID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name", TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'ReasonType'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ReasonType'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ReasonType", TypeName = "nvarchar(50)")]
    public string ReasonType { get; set; } = null!;

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
    /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeaderSalesReason" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="SalesOrderHeaderSalesReason" />.
    /// </value>
    public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

    #endregion

}
