namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class ProductReviewReadModel
  : IEntityReadModel
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
  ///   Gets or sets the property value for 'ReviewerName'.
  /// </summary>
  /// <value>
  ///   The property value for 'ReviewerName'.
  /// </value>
  public string ReviewerName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'ReviewDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ReviewDate'.
  /// </value>
  public DateTime ReviewDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EmailAddress'.
  /// </summary>
  /// <value>
  ///   The property value for 'EmailAddress'.
  /// </value>
  public string EmailAddress { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Rating'.
  /// </summary>
  /// <value>
  ///   The property value for 'Rating'.
  /// </value>
  public int Rating { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Comments'.
  /// </summary>
  /// <value>
  ///   The property value for 'Comments'.
  /// </value>
  public string? Comments { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
