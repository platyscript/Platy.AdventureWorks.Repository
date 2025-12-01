using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'PurchaseOrderDetail'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("PurchaseOrderDetail", Schema = "Purchasing")]
public partial class PurchaseOrderDetail
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderDetail"/> class.
    /// </summary>
    public PurchaseOrderDetail()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'PurchaseOrderID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PurchaseOrderID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("PurchaseOrderID", TypeName = "int")]
    public int PurchaseOrderId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PurchaseOrderDetailID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PurchaseOrderDetailID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("PurchaseOrderDetailID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'DueDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'DueDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("DueDate", TypeName = "datetime")]
    public DateTime DueDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'OrderQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'OrderQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("OrderQty", TypeName = "smallint")]
    public short OrderQty { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductID", TypeName = "int")]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'UnitPrice'.
    /// </summary>
    /// <value>
    /// The property value representing column 'UnitPrice'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice", TypeName = "money")]
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'LineTotal'.
    /// </summary>
    /// <value>
    /// The property value representing column 'LineTotal'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("LineTotal", TypeName = "money")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
    public decimal LineTotal { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ReceivedQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ReceivedQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ReceivedQty", TypeName = "decimal(8,2)")]
    public decimal ReceivedQty { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'RejectedQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'RejectedQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("RejectedQty", TypeName = "decimal(8,2)")]
    public decimal RejectedQty { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StockedQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StockedQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StockedQty", TypeName = "decimal(9,2)")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
    public decimal StockedQty { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="Product" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Product" />.
    /// </value>
    /// <seealso cref="ProductId" />
    public virtual Product Product { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="PurchaseOrderHeader" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="PurchaseOrderHeader" />.
    /// </value>
    /// <seealso cref="PurchaseOrderId" />
    public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; } = null!;

    #endregion

}
