using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'SalesOrderHeaderSalesReason'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("SalesOrderHeaderSalesReason", Schema = "Sales")]
public partial class SalesOrderHeaderSalesReason
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderSalesReason"/> class.
    /// </summary>
    public SalesOrderHeaderSalesReason()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'SalesOrderID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'SalesOrderID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("SalesOrderID", TypeName = "int")]
    public int SalesOrderId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'SalesReasonID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'SalesReasonID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("SalesReasonID", TypeName = "int")]
    public int SalesReasonId { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="SalesOrderHeader" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="SalesOrderHeader" />.
    /// </value>
    /// <seealso cref="SalesOrderId" />
    public virtual SalesOrderHeader SalesOrderHeader { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="SalesReason" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="SalesReason" />.
    /// </value>
    /// <seealso cref="SalesReasonId" />
    public virtual SalesReason SalesReason { get; set; } = null!;

    #endregion

}
