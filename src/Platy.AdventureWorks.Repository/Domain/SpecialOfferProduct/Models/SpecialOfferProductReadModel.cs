namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SpecialOfferProductReadModel
  : IEntityReadModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'SpecialOfferId'.
  /// </summary>
  /// <value>
  ///   The property value for 'SpecialOfferId'.
  /// </value>
  public int SpecialOfferId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ProductId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductId'.
  /// </value>
  public int ProductId { get; set; }

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
