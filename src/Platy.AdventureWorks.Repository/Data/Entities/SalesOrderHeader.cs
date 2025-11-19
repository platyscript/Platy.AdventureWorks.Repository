using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesOrderHeader'.
/// </summary>
[Table("SalesOrderHeader", Schema = "Sales")]
public class SalesOrderHeader
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderHeader" /> class.
  /// </summary>
  public SalesOrderHeader()
  {
    #region Generated Constructor

    SalesOrderDetails = new HashSet<SalesOrderDetail>();
    SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesOrderID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesOrderID'.
  /// </value>
  [Key]
  [Column("SalesOrderID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'RevisionNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'RevisionNumber'.
  /// </value>
  [Column("RevisionNumber", TypeName = "tinyint")]
  public byte RevisionNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'OrderDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'OrderDate'.
  /// </value>
  [Column("OrderDate", TypeName = "datetime")]
  public DateTime OrderDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'DueDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'DueDate'.
  /// </value>
  [Column("DueDate", TypeName = "datetime")]
  public DateTime DueDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ShipDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShipDate'.
  /// </value>
  [Column("ShipDate", TypeName = "datetime")]
  public DateTime? ShipDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Status'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Status'.
  /// </value>
  [Column("Status", TypeName = "tinyint")]
  public byte Status { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'OnlineOrderFlag'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'OnlineOrderFlag'.
  /// </value>
  [Column("OnlineOrderFlag", TypeName = "bit")]
  public bool OnlineOrderFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesOrderNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesOrderNumber'.
  /// </value>
  [Column("SalesOrderNumber", TypeName = "nvarchar(25)")]
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public string SalesOrderNumber { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'PurchaseOrderNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PurchaseOrderNumber'.
  /// </value>
  [Column("PurchaseOrderNumber", TypeName = "nvarchar(25)")]
  public string? PurchaseOrderNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'AccountNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AccountNumber'.
  /// </value>
  [Column("AccountNumber", TypeName = "nvarchar(15)")]
  public string? AccountNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CustomerID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CustomerID'.
  /// </value>
  [Column("CustomerID", TypeName = "int")]
  public int CustomerId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesPersonID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesPersonID'.
  /// </value>
  [Column("SalesPersonID", TypeName = "int")]
  public int? SalesPersonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TerritoryID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TerritoryID'.
  /// </value>
  [Column("TerritoryID", TypeName = "int")]
  public int? TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'BillToAddressID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BillToAddressID'.
  /// </value>
  [Column("BillToAddressID", TypeName = "int")]
  public int BillToAddressId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ShipToAddressID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShipToAddressID'.
  /// </value>
  [Column("ShipToAddressID", TypeName = "int")]
  public int ShipToAddressId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ShipMethodID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShipMethodID'.
  /// </value>
  [Column("ShipMethodID", TypeName = "int")]
  public int ShipMethodId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CreditCardID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CreditCardID'.
  /// </value>
  [Column("CreditCardID", TypeName = "int")]
  public int? CreditCardId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CreditCardApprovalCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CreditCardApprovalCode'.
  /// </value>
  [Column("CreditCardApprovalCode", TypeName = "varchar(15)")]
  public string? CreditCardApprovalCode { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CurrencyRateID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CurrencyRateID'.
  /// </value>
  [Column("CurrencyRateID", TypeName = "int")]
  public int? CurrencyRateId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SubTotal'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SubTotal'.
  /// </value>
  [Column("SubTotal", TypeName = "money")]
  public decimal SubTotal { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TaxAmt'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TaxAmt'.
  /// </value>
  [Column("TaxAmt", TypeName = "money")]
  public decimal TaxAmt { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Freight'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Freight'.
  /// </value>
  [Column("Freight", TypeName = "money")]
  public decimal Freight { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TotalDue'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TotalDue'.
  /// </value>
  [Column("TotalDue", TypeName = "money")]
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public decimal TotalDue { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Comment'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Comment'.
  /// </value>
  [Column("Comment", TypeName = "nvarchar(128)")]
  public string? Comment { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'rowguid'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'rowguid'.
  /// </value>
  [Column("rowguid", TypeName = "uniqueidentifier")]
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ModifiedDate'.
  /// </value>
  [Column("ModifiedDate", TypeName = "datetime")]
  public DateTime ModifiedDate { get; set; }

  #endregion

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Address" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Address" />.
  /// </value>
  /// <seealso cref="BillToAddressId" />
  public virtual Address BillToAddress { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="CreditCard" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="CreditCard" />.
  /// </value>
  /// <seealso cref="CreditCardId" />
  public virtual CreditCard? CreditCard { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="CurrencyRate" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="CurrencyRate" />.
  /// </value>
  /// <seealso cref="CurrencyRateId" />
  public virtual CurrencyRate? CurrencyRate { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Customer" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Customer" />.
  /// </value>
  /// <seealso cref="CustomerId" />
  public virtual Customer Customer { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderDetail" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderDetail" />.
  /// </value>
  public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderHeaderSalesReason" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderHeaderSalesReason" />.
  /// </value>
  public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesPerson" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesPerson" />.
  /// </value>
  /// <seealso cref="SalesPersonId" />
  public virtual SalesPerson? SalesPerson { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesTerritory" />.
  /// </value>
  /// <seealso cref="TerritoryId" />
  public virtual SalesTerritory? SalesTerritory { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="ShipMethod" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="ShipMethod" />.
  /// </value>
  /// <seealso cref="ShipMethodId" />
  public virtual ShipMethod ShipMethod { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Address" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Address" />.
  /// </value>
  /// <seealso cref="ShipToAddressId" />
  public virtual Address ShipToAddress { get; set; } = null!;

  #endregion
}
