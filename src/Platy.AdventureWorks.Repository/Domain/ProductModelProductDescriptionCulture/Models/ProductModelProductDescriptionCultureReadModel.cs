namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class ProductModelProductDescriptionCultureReadModel
  : IEntityReadModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'ProductModelId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductModelId'.
  /// </value>
  public int ProductModelId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ProductDescriptionId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductDescriptionId'.
  /// </value>
  public int ProductDescriptionId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CultureId'.
  /// </summary>
  /// <value>
  ///   The property value for 'CultureId'.
  /// </value>
  public string CultureId { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
