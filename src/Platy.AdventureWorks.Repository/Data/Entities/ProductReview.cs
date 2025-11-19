using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ProductReview'.
/// </summary>
[Table("ProductReview", Schema = "Production")]
public class ProductReview
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductReview" /> class.
  /// </summary>
  public ProductReview()
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
  ///   Gets or sets the property value representing column 'ProductReviewID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductReviewID'.
  /// </value>
  [Key]
  [Column("ProductReviewID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductID'.
  /// </value>
  [Column("ProductID", TypeName = "int")]
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ReviewerName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ReviewerName'.
  /// </value>
  [Column("ReviewerName", TypeName = "nvarchar(50)")]
  public string ReviewerName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'ReviewDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ReviewDate'.
  /// </value>
  [Column("ReviewDate", TypeName = "datetime")]
  public DateTime ReviewDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EmailAddress'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EmailAddress'.
  /// </value>
  [Column("EmailAddress", TypeName = "nvarchar(50)")]
  public string EmailAddress { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Rating'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Rating'.
  /// </value>
  [Column("Rating", TypeName = "int")]
  public int Rating { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Comments'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Comments'.
  /// </value>
  [Column("Comments", TypeName = "nvarchar(3850)")]
  public string? Comments { get; set; }

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
