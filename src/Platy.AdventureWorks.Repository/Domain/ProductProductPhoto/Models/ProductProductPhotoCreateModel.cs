namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class ProductProductPhotoCreateModel
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
  ///   Gets or sets the property value for 'ProductPhotoId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductPhotoId'.
  /// </value>
  public int ProductPhotoId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Primary'.
  /// </summary>
  /// <value>
  ///   The property value for 'Primary'.
  /// </value>
  public bool Primary { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
