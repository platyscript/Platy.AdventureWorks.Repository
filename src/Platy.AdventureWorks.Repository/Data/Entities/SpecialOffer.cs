using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SpecialOffer'.
/// </summary>
[Table("SpecialOffer", Schema = "Sales")]
public class SpecialOffer
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SpecialOffer" /> class.
  /// </summary>
  public SpecialOffer()
  {
    #region Generated Constructor

    SpecialOfferProducts = new HashSet<SpecialOfferProduct>();

    #endregion
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SpecialOfferProduct" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SpecialOfferProduct" />.
  /// </value>
  public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'SpecialOfferID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SpecialOfferID'.
  /// </value>
  [Key]
  [Column("SpecialOfferID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Description'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Description'.
  /// </value>
  [Column("Description", TypeName = "nvarchar(255)")]
  public string Description { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'DiscountPct'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'DiscountPct'.
  /// </value>
  [Column("DiscountPct", TypeName = "smallmoney")]
  public decimal DiscountPct { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Type'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Type'.
  /// </value>
  [Column("Type", TypeName = "nvarchar(50)")]
  public string Type { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Category'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Category'.
  /// </value>
  [Column("Category", TypeName = "nvarchar(50)")]
  public string Category { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StartDate'.
  /// </value>
  [Column("StartDate", TypeName = "datetime")]
  public DateTime StartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EndDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EndDate'.
  /// </value>
  [Column("EndDate", TypeName = "datetime")]
  public DateTime EndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'MinQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MinQty'.
  /// </value>
  [Column("MinQty", TypeName = "int")]
  public int MinQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'MaxQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MaxQty'.
  /// </value>
  [Column("MaxQty", TypeName = "int")]
  public int? MaxQty { get; set; }

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
