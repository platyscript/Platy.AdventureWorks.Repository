using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductSubcategory'.
/// </summary>
[Table("ProductSubcategory", Schema = "Production")]
public class ProductSubcategory
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductSubcategory" /> class.
  /// </summary>
  public ProductSubcategory()
  {
    #region Generated Constructor

    Products = new HashSet<Product>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductSubcategoryID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductSubcategoryID'.
  /// </value>
  [Key]
  [Column("ProductSubcategoryID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductCategoryID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductCategoryID'.
  /// </value>
  [Column("ProductCategoryID", TypeName = "int")]
  public int ProductCategoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

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
  ///   Gets or sets the navigation property for entity <see cref="ProductCategory" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="ProductCategory" />.
  /// </value>
  /// <seealso cref="ProductCategoryId" />
  public virtual ProductCategory ProductCategory { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="Product" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="Product" />.
  /// </value>
  public virtual ICollection<Product> Products { get; set; }

  #endregion
}
