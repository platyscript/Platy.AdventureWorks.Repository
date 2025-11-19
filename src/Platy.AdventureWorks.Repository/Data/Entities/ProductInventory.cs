using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductInventory'.
/// </summary>
[Table("ProductInventory", Schema = "Production")]
public class ProductInventory
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductInventory" /> class.
  /// </summary>
  public ProductInventory()
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
  ///   Gets or sets the property value representing column 'LocationID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LocationID'.
  /// </value>
  [Key]
  [Column("LocationID", TypeName = "smallint")]
  public short LocationId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Shelf'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Shelf'.
  /// </value>
  [Column("Shelf", TypeName = "nvarchar(10)")]
  public string Shelf { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Bin'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Bin'.
  /// </value>
  [Column("Bin", TypeName = "tinyint")]
  public byte Bin { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Quantity'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Quantity'.
  /// </value>
  [Column("Quantity", TypeName = "smallint")]
  public short Quantity { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="Location" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Location" />.
  /// </value>
  /// <seealso cref="LocationId" />
  public virtual Location Location { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Product" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Product" />.
  /// </value>
  /// <seealso cref="ProductId" />
  public virtual Product Product { get; set; } = null!;

  #endregion
}
