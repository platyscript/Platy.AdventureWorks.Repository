using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesPersonQuotaHistory'.
/// </summary>
[Table("SalesPersonQuotaHistory", Schema = "Sales")]
public class SalesPersonQuotaHistory
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesPersonQuotaHistory" /> class.
  /// </summary>
  public SalesPersonQuotaHistory()
  {
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesPerson" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesPerson" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual SalesPerson SalesPerson { get; set; } = null!;

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Key]
  [Column("BusinessEntityID", TypeName = "int")]
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'QuotaDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'QuotaDate'.
  /// </value>
  [Key]
  [Column("QuotaDate", TypeName = "datetime")]
  public DateTime QuotaDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesQuota'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesQuota'.
  /// </value>
  [Column("SalesQuota", TypeName = "money")]
  public decimal SalesQuota { get; set; }

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
