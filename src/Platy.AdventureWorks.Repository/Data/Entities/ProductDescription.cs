using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductDescription'.
/// </summary>
[Table("ProductDescription", Schema = "Production")]
public class ProductDescription
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductDescription" /> class.
  /// </summary>
  public ProductDescription()
  {
    #region Generated Constructor

    ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();

    #endregion
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
  /// </value>
  public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductDescriptionID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductDescriptionID'.
  /// </value>
  [Key]
  [Column("ProductDescriptionID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Description'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Description'.
  /// </value>
  [Column("Description", TypeName = "nvarchar(400)")]
  public string Description { get; set; } = null!;

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
}
