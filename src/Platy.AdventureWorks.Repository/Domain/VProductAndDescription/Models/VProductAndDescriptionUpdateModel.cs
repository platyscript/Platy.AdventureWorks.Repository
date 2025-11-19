namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VProductAndDescriptionUpdateModel
  : IEntityUpdateModel
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
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'ProductModel'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductModel'.
  /// </value>
  public string ProductModel { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CultureId'.
  /// </summary>
  /// <value>
  ///   The property value for 'CultureId'.
  /// </value>
  public string CultureId { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Description'.
  /// </summary>
  /// <value>
  ///   The property value for 'Description'.
  /// </value>
  public string Description { get; set; } = null!;

  #endregion
}
