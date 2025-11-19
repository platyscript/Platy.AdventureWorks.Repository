using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Location'.
/// </summary>
[Table("Location", Schema = "Production")]
public class Location
  : HasDomainEventsBase, IIdentity<short>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Location" /> class.
  /// </summary>
  public Location()
  {
    #region Generated Constructor

    ProductInventories = new HashSet<ProductInventory>();
    WorkOrderRoutings = new HashSet<WorkOrderRouting>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'LocationID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LocationID'.
  /// </value>
  [Key]
  [Column("LocationID", TypeName = "smallint")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public short Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'CostRate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CostRate'.
  /// </value>
  [Column("CostRate", TypeName = "smallmoney")]
  public decimal CostRate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Availability'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Availability'.
  /// </value>
  [Column("Availability", TypeName = "decimal(8,2)")]
  public decimal Availability { get; set; }

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
  ///   Gets or sets the navigation collection for entity <see cref="ProductInventory" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="ProductInventory" />.
  /// </value>
  public virtual ICollection<ProductInventory> ProductInventories { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="WorkOrderRouting" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="WorkOrderRouting" />.
  /// </value>
  public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

  #endregion
}
