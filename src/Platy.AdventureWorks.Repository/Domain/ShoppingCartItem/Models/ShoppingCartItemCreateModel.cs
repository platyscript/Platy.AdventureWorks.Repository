namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class ShoppingCartItemCreateModel
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
  ///   Gets or sets the property value for 'ShoppingCartId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ShoppingCartId'.
  /// </value>
  public string ShoppingCartId { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Quantity'.
  /// </summary>
  /// <value>
  ///   The property value for 'Quantity'.
  /// </value>
  public int Quantity { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ProductId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ProductId'.
  /// </value>
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'DateCreated'.
  /// </summary>
  /// <value>
  ///   The property value for 'DateCreated'.
  /// </value>
  public DateTime DateCreated { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
