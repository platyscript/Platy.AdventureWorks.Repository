using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesOrderHeaderSalesReason'.
/// </summary>
[Table("SalesOrderHeaderSalesReason", Schema = "Sales")]
public class SalesOrderHeaderSalesReason
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderHeaderSalesReason" /> class.
  /// </summary>
  public SalesOrderHeaderSalesReason()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesOrderID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesOrderID'.
  /// </value>
  [Key]
  [Column("SalesOrderID", TypeName = "int")]
  public int SalesOrderId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesReasonID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesReasonID'.
  /// </value>
  [Key]
  [Column("SalesReasonID", TypeName = "int")]
  public int SalesReasonId { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="SalesOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesOrderHeader" />.
  /// </value>
  /// <seealso cref="SalesOrderId" />
  public virtual SalesOrderHeader SalesOrderHeader { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesReason" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesReason" />.
  /// </value>
  /// <seealso cref="SalesReasonId" />
  public virtual SalesReason SalesReason { get; set; } = null!;

  #endregion
}
