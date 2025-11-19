namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class ProductListPriceHistoryCreateModel
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
  ///   Gets or sets the property value for 'ListPrice'.
  /// </summary>
  /// <value>
  ///   The property value for 'ListPrice'.
  /// </value>
  public decimal ListPrice { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
