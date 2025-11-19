using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'ShipMethod'.
/// </summary>
[Table("ShipMethod", Schema = "Purchasing")]
public class ShipMethod
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShipMethod" /> class.
  /// </summary>
  public ShipMethod()
  {
    #region Generated Constructor

    PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
    SalesOrderHeaders = new HashSet<SalesOrderHeader>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'ShipMethodID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShipMethodID'.
  /// </value>
  [Key]
  [Column("ShipMethodID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'ShipBase'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShipBase'.
  /// </value>
  [Column("ShipBase", TypeName = "money")]
  public decimal ShipBase { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ShipRate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShipRate'.
  /// </value>
  [Column("ShipRate", TypeName = "money")]
  public decimal ShipRate { get; set; }

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
  ///   Gets or sets the navigation collection for entity <see cref="PurchaseOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="PurchaseOrderHeader" />.
  /// </value>
  public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </value>
  public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

  #endregion
}
