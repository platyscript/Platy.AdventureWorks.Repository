namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class TransactionHistoryArchiveReadModel
  : IEntityReadModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'TransactionId'.
  /// </summary>
  /// <value>
  ///   The property value for 'TransactionId'.
  /// </value>
  public int TransactionId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ProductId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductId'.
  /// </value>
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ReferenceOrderId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ReferenceOrderId'.
  /// </value>
  public int ReferenceOrderId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ReferenceOrderLineId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ReferenceOrderLineId'.
  /// </value>
  public int ReferenceOrderLineId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TransactionDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'TransactionDate'.
  /// </value>
  public DateTime TransactionDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TransactionType'.
  /// </summary>
  /// <value>
  ///   The property value for 'TransactionType'.
  /// </value>
  public string TransactionType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Quantity'.
  /// </summary>
  /// <value>
  ///   The property value for 'Quantity'.
  /// </value>
  public int Quantity { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ActualCost'.
  /// </summary>
  /// <value>
  ///   The property value for 'ActualCost'.
  /// </value>
  public decimal ActualCost { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
