namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class BillOfMaterialsReadModel
  : IEntityReadModel
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
  ///   Gets or sets the property value for 'ProductAssemblyId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductAssemblyId'.
  /// </value>
  public int? ProductAssemblyId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ComponentId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ComponentId'.
  /// </value>
  public int ComponentId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'StartDate'.
  /// </value>
  public DateTime StartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EndDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'EndDate'.
  /// </value>
  public DateTime? EndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'UnitMeasureCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'UnitMeasureCode'.
  /// </value>
  public string UnitMeasureCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'BOMLevel'.
  /// </summary>
  /// <value>
  ///   The property value for 'BOMLevel'.
  /// </value>
  public short BOMLevel { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'PerAssemblyQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'PerAssemblyQty'.
  /// </value>
  public decimal PerAssemblyQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
