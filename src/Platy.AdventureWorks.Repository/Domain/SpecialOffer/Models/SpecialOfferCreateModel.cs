namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SpecialOfferCreateModel
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
  ///   Gets or sets the property value for 'Description'.
  /// </summary>
  /// <value>
  ///   The property value for 'Description'.
  /// </value>
  public string Description { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'DiscountPct'.
  /// </summary>
  /// <value>
  ///   The property value for 'DiscountPct'.
  /// </value>
  public decimal DiscountPct { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Type'.
  /// </summary>
  /// <value>
  ///   The property value for 'Type'.
  /// </value>
  public string Type { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Category'.
  /// </summary>
  /// <value>
  ///   The property value for 'Category'.
  /// </value>
  public string Category { get; set; } = null!;

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
  public DateTime EndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'MinQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'MinQty'.
  /// </value>
  public int MinQty { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'MaxQty'.
  /// </summary>
  /// <value>
  ///   The property value for 'MaxQty'.
  /// </value>
  public int? MaxQty { get; set; }

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
