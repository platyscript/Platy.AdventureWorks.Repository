using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'PurchaseOrderHeader'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("PurchaseOrderHeader", Schema = "Purchasing")]
public partial class PurchaseOrderHeader
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderHeader"/> class.
    /// </summary>
    public PurchaseOrderHeader()
    {
        #region Generated Constructor
        PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
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
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'RevisionNumber'.
    /// </summary>
    /// <value>
    /// The property value representing column 'RevisionNumber'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("RevisionNumber", TypeName = "tinyint")]
    public byte RevisionNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Status'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Status'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Status", TypeName = "tinyint")]
    public byte Status { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EmployeeID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EmployeeID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EmployeeID", TypeName = "int")]
    public int EmployeeId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'VendorID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'VendorID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("VendorID", TypeName = "int")]
    public int VendorId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ShipMethodID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ShipMethodID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ShipMethodID", TypeName = "int")]
    public int ShipMethodId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'OrderDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'OrderDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("OrderDate", TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ShipDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ShipDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ShipDate", TypeName = "datetime")]
    public DateTime? ShipDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'SubTotal'.
    /// </summary>
    /// <value>
    /// The property value representing column 'SubTotal'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("SubTotal", TypeName = "money")]
    public decimal SubTotal { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'TaxAmt'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TaxAmt'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TaxAmt", TypeName = "money")]
    public decimal TaxAmt { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Freight'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Freight'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Freight", TypeName = "money")]
    public decimal Freight { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'TotalDue'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TotalDue'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TotalDue", TypeName = "money")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
    public decimal TotalDue { get; set; }

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
    /// <seealso cref="EmployeeId" />
    public virtual Employee Employee { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="PurchaseOrderDetail" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="PurchaseOrderDetail" />.
    /// </value>
    public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="ShipMethod" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="ShipMethod" />.
    /// </value>
    /// <seealso cref="ShipMethodId" />
    public virtual ShipMethod ShipMethod { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Vendor" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Vendor" />.
    /// </value>
    /// <seealso cref="VendorId" />
    public virtual Vendor Vendor { get; set; } = null!;

    #endregion

}
