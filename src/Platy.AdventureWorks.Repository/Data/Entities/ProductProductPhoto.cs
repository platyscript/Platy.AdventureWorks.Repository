using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductProductPhoto'.
/// </summary>
[Table("ProductProductPhoto", Schema = "Production")]
public class ProductProductPhoto
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductProductPhoto" /> class.
  /// </summary>
  public ProductProductPhoto()
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
  ///   Gets or sets the property value representing column 'ProductPhotoID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductPhotoID'.
  /// </value>
  [Key]
  [Column("ProductPhotoID", TypeName = "int")]
  public int ProductPhotoId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Primary'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Primary'.
  /// </value>
  [Column("Primary", TypeName = "bit")]
  public bool Primary { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="ProductPhoto" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="ProductPhoto" />.
  /// </value>
  /// <seealso cref="ProductPhotoId" />
  public virtual ProductPhoto ProductPhoto { get; set; } = null!;

  #endregion
}
