namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class ProductModelIllustrationCreateModel
  : IEntityCreateModel
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
  ///   Gets or sets the property value for 'IllustrationId'.
  /// </summary>
  /// <value>
  ///   The property value for 'IllustrationId'.
  /// </value>
  public int IllustrationId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
