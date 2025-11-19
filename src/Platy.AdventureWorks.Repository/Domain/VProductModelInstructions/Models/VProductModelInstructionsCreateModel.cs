namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VProductModelInstructionsCreateModel
  : IEntityCreateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'Id'.
  /// </summary>
  /// <value>
  ///   The property value for 'Id'.
  /// </value>
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Instructions'.
  /// </summary>
  /// <value>
  ///   The property value for 'Instructions'.
  /// </value>
  public string? Instructions { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LocationId'.
  /// </summary>
  /// <value>
  ///   The property value for 'LocationId'.
  /// </value>
  public int? LocationId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SetupHours'.
  /// </summary>
  /// <value>
  ///   The property value for 'SetupHours'.
  /// </value>
  public decimal? SetupHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'MachineHours'.
  /// </summary>
  /// <value>
  ///   The property value for 'MachineHours'.
  /// </value>
  public decimal? MachineHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LaborHours'.
  /// </summary>
  /// <value>
  ///   The property value for 'LaborHours'.
  /// </value>
  public decimal? LaborHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LotSize'.
  /// </summary>
  /// <value>
  ///   The property value for 'LotSize'.
  /// </value>
  public int? LotSize { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Step'.
  /// </summary>
  /// <value>
  ///   The property value for 'Step'.
  /// </value>
  public string? Step { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Rowguid'.
  /// </summary>
  /// <value>
  ///   The property value for 'Rowguid'.
  /// </value>
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
