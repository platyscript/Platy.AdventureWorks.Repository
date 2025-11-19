using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vProductModelInstructions'.
/// </summary>
[Table("vProductModelInstructions", Schema = "Production")]
public class VProductModelInstructions
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductModelInstructions" /> class.
  /// </summary>
  public VProductModelInstructions()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductModelID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductModelID'.
  /// </value>
  [Column("ProductModelID", TypeName = "int")]
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
  ///   Gets or sets the property value representing column 'Instructions'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Instructions'.
  /// </value>
  [Column("Instructions", TypeName = "nvarchar(max)")]
  public string? Instructions { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LocationID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LocationID'.
  /// </value>
  [Column("LocationID", TypeName = "int")]
  public int? LocationId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SetupHours'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SetupHours'.
  /// </value>
  [Column("SetupHours", TypeName = "decimal(9,4)")]
  public decimal? SetupHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'MachineHours'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MachineHours'.
  /// </value>
  [Column("MachineHours", TypeName = "decimal(9,4)")]
  public decimal? MachineHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LaborHours'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LaborHours'.
  /// </value>
  [Column("LaborHours", TypeName = "decimal(9,4)")]
  public decimal? LaborHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LotSize'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LotSize'.
  /// </value>
  [Column("LotSize", TypeName = "int")]
  public int? LotSize { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Step'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Step'.
  /// </value>
  [Column("Step", TypeName = "nvarchar(1024)")]
  public string? Step { get; set; }

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
