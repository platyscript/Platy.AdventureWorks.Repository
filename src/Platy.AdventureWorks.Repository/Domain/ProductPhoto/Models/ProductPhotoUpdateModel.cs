namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class ProductPhotoUpdateModel
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
  ///   Gets or sets the property value for 'ThumbNailPhoto'.
  /// </summary>
  /// <value>
  ///   The property value for 'ThumbNailPhoto'.
  /// </value>
  public byte[]? ThumbNailPhoto { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ThumbnailPhotoFileName'.
  /// </summary>
  /// <value>
  ///   The property value for 'ThumbnailPhotoFileName'.
  /// </value>
  public string? ThumbnailPhotoFileName { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LargePhoto'.
  /// </summary>
  /// <value>
  ///   The property value for 'LargePhoto'.
  /// </value>
  public byte[]? LargePhoto { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LargePhotoFileName'.
  /// </summary>
  /// <value>
  ///   The property value for 'LargePhotoFileName'.
  /// </value>
  public string? LargePhotoFileName { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
