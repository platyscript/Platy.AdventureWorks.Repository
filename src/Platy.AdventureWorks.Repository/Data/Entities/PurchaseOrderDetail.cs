using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'PurchaseOrderDetail'.
/// </summary>
[Table("PurchaseOrderDetail", Schema = "Purchasing")]
public class PurchaseOrderDetail
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PurchaseOrderDetail" /> class.
  /// </summary>
  public PurchaseOrderDetail()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'PurchaseOrderID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PurchaseOrderID'.
  /// </value>
  [Key]
  [Column("PurchaseOrderID", TypeName = "int")]
  public int PurchaseOrderId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PurchaseOrderDetailID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PurchaseOrderDetailID'.
  /// </value>
  [Key]
  [Column("PurchaseOrderDetailID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'DueDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'DueDate'.
  /// </value>
  [Column("DueDate", TypeName = "datetime")]
  public DateTime DueDate { get; set; }

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
  ///   Gets or sets the property value representing column 'UnitPrice'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'UnitPrice'.
  /// </value>
  [Column("UnitPrice", TypeName = "money")]
  public decimal UnitPrice { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LineTotal'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LineTotal'.
  /// </value>
  [Column("LineTotal", TypeName = "money")]
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public decimal LineTotal { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ReceivedQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ReceivedQty'.
  /// </value>
  [Column("ReceivedQty", TypeName = "decimal(8,2)")]
  public decimal ReceivedQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'RejectedQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'RejectedQty'.
  /// </value>
  [Column("RejectedQty", TypeName = "decimal(8,2)")]
  public decimal RejectedQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StockedQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StockedQty'.
  /// </value>
  [Column("StockedQty", TypeName = "decimal(9,2)")]
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public decimal StockedQty { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="Product" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Product" />.
  /// </value>
  /// <seealso cref="ProductId" />
  public virtual Product Product { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="PurchaseOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="PurchaseOrderHeader" />.
  /// </value>
  /// <seealso cref="PurchaseOrderId" />
  public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; } = null!;

  #endregion
}
