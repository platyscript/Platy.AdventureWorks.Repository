using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'WorkOrderRouting'.
/// </summary>
[Table("WorkOrderRouting", Schema = "Production")]
public class WorkOrderRouting
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="WorkOrderRouting" /> class.
  /// </summary>
  public WorkOrderRouting()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'WorkOrderID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'WorkOrderID'.
  /// </value>
  [Key]
  [Column("WorkOrderID", TypeName = "int")]
  public int WorkOrderId { get; set; }

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
  ///   Gets or sets the property value representing column 'OperationSequence'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'OperationSequence'.
  /// </value>
  [Key]
  [Column("OperationSequence", TypeName = "smallint")]
  public short OperationSequence { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LocationID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LocationID'.
  /// </value>
  [Column("LocationID", TypeName = "smallint")]
  public short LocationId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ScheduledStartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ScheduledStartDate'.
  /// </value>
  [Column("ScheduledStartDate", TypeName = "datetime")]
  public DateTime ScheduledStartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ScheduledEndDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ScheduledEndDate'.
  /// </value>
  [Column("ScheduledEndDate", TypeName = "datetime")]
  public DateTime ScheduledEndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ActualStartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ActualStartDate'.
  /// </value>
  [Column("ActualStartDate", TypeName = "datetime")]
  public DateTime? ActualStartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ActualEndDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ActualEndDate'.
  /// </value>
  [Column("ActualEndDate", TypeName = "datetime")]
  public DateTime? ActualEndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ActualResourceHrs'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ActualResourceHrs'.
  /// </value>
  [Column("ActualResourceHrs", TypeName = "decimal(9,4)")]
  public decimal? ActualResourceHrs { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PlannedCost'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PlannedCost'.
  /// </value>
  [Column("PlannedCost", TypeName = "money")]
  public decimal PlannedCost { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ActualCost'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ActualCost'.
  /// </value>
  [Column("ActualCost", TypeName = "money")]
  public decimal? ActualCost { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="Location" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Location" />.
  /// </value>
  /// <seealso cref="LocationId" />
  public virtual Location Location { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="WorkOrder" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="WorkOrder" />.
  /// </value>
  /// <seealso cref="WorkOrderId" />
  public virtual WorkOrder WorkOrder { get; set; } = null!;

  #endregion
}
