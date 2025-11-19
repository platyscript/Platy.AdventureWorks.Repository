using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductModelProductDescriptionCulture'.
/// </summary>
[Table("ProductModelProductDescriptionCulture", Schema = "Production")]
public class ProductModelProductDescriptionCulture
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductModelProductDescriptionCulture" /> class.
  /// </summary>
  public ProductModelProductDescriptionCulture()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductModelID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductModelID'.
  /// </value>
  [Key]
  [Column("ProductModelID", TypeName = "int")]
  public int ProductModelId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductDescriptionID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductDescriptionID'.
  /// </value>
  [Key]
  [Column("ProductDescriptionID", TypeName = "int")]
  public int ProductDescriptionId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CultureID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CultureID'.
  /// </value>
  [Key]
  [Column("CultureID", TypeName = "nchar(6)")]
  public string CultureId { get; set; } = null!;

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
  ///   Gets or sets the navigation property for entity <see cref="Culture" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Culture" />.
  /// </value>
  /// <seealso cref="CultureId" />
  public virtual Culture Culture { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="ProductDescription" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="ProductDescription" />.
  /// </value>
  /// <seealso cref="ProductDescriptionId" />
  public virtual ProductDescription ProductDescription { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="ProductModel" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="ProductModel" />.
  /// </value>
  /// <seealso cref="ProductModelId" />
  public virtual ProductModel ProductModel { get; set; } = null!;

  #endregion
}
