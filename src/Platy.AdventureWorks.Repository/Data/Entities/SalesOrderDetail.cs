using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesOrderDetail'.
/// </summary>
[Table("SalesOrderDetail", Schema = "Sales")]
public class SalesOrderDetail
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderDetail" /> class.
  /// </summary>
  public SalesOrderDetail()
  {
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
  public int SalesOrderId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesOrderDetailID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesOrderDetailID'.
  /// </value>
  [Key]
  [Column("SalesOrderDetailID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CarrierTrackingNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CarrierTrackingNumber'.
  /// </value>
  [Column("CarrierTrackingNumber", TypeName = "nvarchar(25)")]
  public string? CarrierTrackingNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'OrderQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'OrderQty'.
  /// </value>
  [Column("OrderQty", TypeName = "smallint")]
  public short OrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductID'.
  /// </value>
  [Column("ProductID", TypeName = "int")]
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SpecialOfferID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SpecialOfferID'.
  /// </value>
  [Column("SpecialOfferID", TypeName = "int")]
  public int SpecialOfferId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'UnitPrice'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'UnitPrice'.
  /// </value>
  [Column("UnitPrice", TypeName = "money")]
  public decimal UnitPrice { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'UnitPriceDiscount'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'UnitPriceDiscount'.
  /// </value>
  [Column("UnitPriceDiscount", TypeName = "money")]
  public decimal UnitPriceDiscount { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LineTotal'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LineTotal'.
  /// </value>
  [Column("LineTotal", TypeName = "numeric(38,6)")]
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public decimal LineTotal { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="SalesOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesOrderHeader" />.
  /// </value>
  /// <seealso cref="SalesOrderId" />
  public virtual SalesOrderHeader SalesOrderHeader { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SpecialOfferProduct" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SpecialOfferProduct" />.
  /// </value>
  /// <seealso cref="SpecialOfferId" />
  /// <seealso cref="ProductId" />
  public virtual SpecialOfferProduct SpecialOfferProduct { get; set; } = null!;

  #endregion
}
