using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductPhoto'.
/// </summary>
[Table("ProductPhoto", Schema = "Production")]
public class ProductPhoto
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductPhoto" /> class.
  /// </summary>
  public ProductPhoto()
  {
    #region Generated Constructor

    ProductProductPhotos = new HashSet<ProductProductPhoto>();

    #endregion
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="ProductProductPhoto" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="ProductProductPhoto" />.
  /// </value>
  public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductPhotoID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductPhotoID'.
  /// </value>
  [Key]
  [Column("ProductPhotoID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ThumbNailPhoto'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ThumbNailPhoto'.
  /// </value>
  [Column("ThumbNailPhoto", TypeName = "varbinary(max)")]
  public byte[]? ThumbNailPhoto { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ThumbnailPhotoFileName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ThumbnailPhotoFileName'.
  /// </value>
  [Column("ThumbnailPhotoFileName", TypeName = "nvarchar(50)")]
  public string? ThumbnailPhotoFileName { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LargePhoto'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LargePhoto'.
  /// </value>
  [Column("LargePhoto", TypeName = "varbinary(max)")]
  public byte[]? LargePhoto { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LargePhotoFileName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LargePhotoFileName'.
  /// </value>
  [Column("LargePhotoFileName", TypeName = "nvarchar(50)")]
  public string? LargePhotoFileName { get; set; }

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
