namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class WorkOrderUpdateModel
  : IEntityUpdateModel
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
  ///   Gets or sets the property value for 'ProductId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductId'.
  /// </value>
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'OrderQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'OrderQty'.
  /// </value>
  public int OrderQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'StockedQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'StockedQty'.
  /// </value>
  public int StockedQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ScrappedQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'ScrappedQty'.
  /// </value>
  public short ScrappedQty { get; set; }

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
  ///   Gets or sets the property value for 'DueDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'DueDate'.
  /// </value>
  public DateTime DueDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ScrapReasonId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ScrapReasonId'.
  /// </value>
  public short? ScrapReasonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
