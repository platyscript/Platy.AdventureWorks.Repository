using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'SalesOrderDetail'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("SalesOrderDetail", Schema = "Sales")]
public partial class SalesOrderDetail
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderDetail"/> class.
    /// </summary>
    public SalesOrderDetail()
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
    /// Gets or sets the property value representing column 'SalesOrderDetailID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'SalesOrderDetailID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("SalesOrderDetailID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'CarrierTrackingNumber'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CarrierTrackingNumber'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CarrierTrackingNumber", TypeName = "nvarchar(25)")]
    public string? CarrierTrackingNumber { get; set; }

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
    /// Gets or sets the property value representing column 'SpecialOfferID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'SpecialOfferID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("SpecialOfferID", TypeName = "int")]
    public int SpecialOfferId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'UnitPrice'.
    /// </summary>
    /// <value>
    /// The property value representing column 'UnitPrice'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice", TypeName = "money")]
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'UnitPriceDiscount'.
    /// </summary>
    /// <value>
    /// The property value representing column 'UnitPriceDiscount'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("UnitPriceDiscount", TypeName = "money")]
    public decimal UnitPriceDiscount { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'LineTotal'.
    /// </summary>
    /// <value>
    /// The property value representing column 'LineTotal'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("LineTotal", TypeName = "numeric(38,6)")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
    public decimal LineTotal { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'rowguid'.
    /// </summary>
    /// <value>
    /// The property value representing column 'rowguid'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("rowguid", TypeName = "uniqueidentifier")]
    public Guid Rowguid { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="SpecialOfferProduct" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="SpecialOfferProduct" />.
    /// </value>
    /// <seealso cref="SpecialOfferId" />
    /// <seealso cref="ProductId" />
    public virtual SpecialOfferProduct SpecialOfferProduct { get; set; } = null!;

    #endregion

}
