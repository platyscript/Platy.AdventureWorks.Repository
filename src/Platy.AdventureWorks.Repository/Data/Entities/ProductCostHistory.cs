using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductCostHistory'.
/// </summary>
[Table("ProductCostHistory", Schema = "Production")]
public class ProductCostHistory
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductCostHistory" /> class.
  /// </summary>
  public ProductCostHistory()
  {
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Product" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Product" />.
  /// </value>
  /// <seealso cref="ProductId" />
  public virtual Product Product { get; set; } = null!;

  #endregion

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
  ///   Gets or sets the property value representing column 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StartDate'.
  /// </value>
  [Key]
  [Column("StartDate", TypeName = "datetime")]
  public DateTime StartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EndDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EndDate'.
  /// </value>
  [Column("EndDate", TypeName = "datetime")]
  public DateTime? EndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StandardCost'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StandardCost'.
  /// </value>
  [Column("StandardCost", TypeName = "money")]
  public decimal StandardCost { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ModifiedDate'.
  /// </value>
  [Column("ModifiedDate", TypeName = "datetime")]
  public DateTime ModifiedDate { get; set; }

  #endregion
}
