using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductVendor'.
/// </summary>
[Table("ProductVendor", Schema = "Purchasing")]
public class ProductVendor
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductVendor" /> class.
  /// </summary>
  public ProductVendor()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductID'.
  /// </value>
  [Key]
  [Column("ProductID", TypeName = "int")]
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Key]
  [Column("BusinessEntityID", TypeName = "int")]
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'AverageLeadTime'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AverageLeadTime'.
  /// </value>
  [Column("AverageLeadTime", TypeName = "int")]
  public int AverageLeadTime { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StandardPrice'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StandardPrice'.
  /// </value>
  [Column("StandardPrice", TypeName = "money")]
  public decimal StandardPrice { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LastReceiptCost'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LastReceiptCost'.
  /// </value>
  [Column("LastReceiptCost", TypeName = "money")]
  public decimal? LastReceiptCost { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LastReceiptDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LastReceiptDate'.
  /// </value>
  [Column("LastReceiptDate", TypeName = "datetime")]
  public DateTime? LastReceiptDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'MinOrderQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MinOrderQty'.
  /// </value>
  [Column("MinOrderQty", TypeName = "int")]
  public int MinOrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'MaxOrderQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MaxOrderQty'.
  /// </value>
  [Column("MaxOrderQty", TypeName = "int")]
  public int MaxOrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'OnOrderQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'OnOrderQty'.
  /// </value>
  [Column("OnOrderQty", TypeName = "int")]
  public int? OnOrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'UnitMeasureCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'UnitMeasureCode'.
  /// </value>
  [Column("UnitMeasureCode", TypeName = "nchar(3)")]
  public string UnitMeasureCode { get; set; } = null!;

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
  ///   Gets or sets the navigation property for entity <see cref="UnitMeasure" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="UnitMeasure" />.
  /// </value>
  /// <seealso cref="UnitMeasureCode" />
  public virtual UnitMeasure UnitMeasure { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Vendor" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Vendor" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Vendor Vendor { get; set; } = null!;

  #endregion
}
