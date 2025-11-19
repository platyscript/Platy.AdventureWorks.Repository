using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ShoppingCartItem'.
/// </summary>
[Table("ShoppingCartItem", Schema = "Sales")]
public class ShoppingCartItem
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShoppingCartItem" /> class.
  /// </summary>
  public ShoppingCartItem()
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
  ///   Gets or sets the property value representing column 'ShoppingCartItemID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShoppingCartItemID'.
  /// </value>
  [Key]
  [Column("ShoppingCartItemID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ShoppingCartID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShoppingCartID'.
  /// </value>
  [Column("ShoppingCartID", TypeName = "nvarchar(50)")]
  public string ShoppingCartId { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Quantity'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Quantity'.
  /// </value>
  [Column("Quantity", TypeName = "int")]
  public int Quantity { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductID'.
  /// </value>
  [Column("ProductID", TypeName = "int")]
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'DateCreated'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'DateCreated'.
  /// </value>
  [Column("DateCreated", TypeName = "datetime")]
  public DateTime DateCreated { get; set; }

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
