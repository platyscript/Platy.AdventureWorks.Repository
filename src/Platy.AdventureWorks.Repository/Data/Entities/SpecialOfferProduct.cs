using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SpecialOfferProduct'.
/// </summary>
[Table("SpecialOfferProduct", Schema = "Sales")]
public class SpecialOfferProduct
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SpecialOfferProduct" /> class.
  /// </summary>
  public SpecialOfferProduct()
  {
    #region Generated Constructor

    SalesOrderDetails = new HashSet<SalesOrderDetail>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'SpecialOfferID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SpecialOfferID'.
  /// </value>
  [Key]
  [Column("SpecialOfferID", TypeName = "int")]
  public int SpecialOfferId { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="Product" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Product" />.
  /// </value>
  /// <seealso cref="ProductId" />
  public virtual Product Product { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderDetail" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderDetail" />.
  /// </value>
  public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SpecialOffer" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SpecialOffer" />.
  /// </value>
  /// <seealso cref="SpecialOfferId" />
  public virtual SpecialOffer SpecialOffer { get; set; } = null!;

  #endregion
}
