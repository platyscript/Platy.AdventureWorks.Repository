namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class ProductVendorCreateModel
  : IEntityCreateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'ProductId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductId'.
  /// </value>
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'BusinessEntityId'.
  /// </summary>
  /// <value>
  ///   The property value for 'BusinessEntityId'.
  /// </value>
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'AverageLeadTime'.
  /// </summary>
  /// <value>
  ///   The property value for 'AverageLeadTime'.
  /// </value>
  public int AverageLeadTime { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'StandardPrice'.
  /// </summary>
  /// <value>
  ///   The property value for 'StandardPrice'.
  /// </value>
  public decimal StandardPrice { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LastReceiptCost'.
  /// </summary>
  /// <value>
  ///   The property value for 'LastReceiptCost'.
  /// </value>
  public decimal? LastReceiptCost { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LastReceiptDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'LastReceiptDate'.
  /// </value>
  public DateTime? LastReceiptDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'MinOrderQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'MinOrderQty'.
  /// </value>
  public int MinOrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'MaxOrderQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'MaxOrderQty'.
  /// </value>
  public int MaxOrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'OnOrderQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'OnOrderQty'.
  /// </value>
  public int? OnOrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'UnitMeasureCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'UnitMeasureCode'.
  /// </value>
  public string UnitMeasureCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
