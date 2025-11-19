namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class CreditCardReadModel
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
  ///   Gets or sets the property value for 'CardType'.
  /// </summary>
  /// <value>
  ///   The property value for 'CardType'.
  /// </value>
  public string CardType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CardNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'CardNumber'.
  /// </value>
  public string CardNumber { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'ExpMonth'.
  /// </summary>
  /// <value>
  ///   The property value for 'ExpMonth'.
  /// </value>
  public byte ExpMonth { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ExpYear'.
  /// </summary>
  /// <value>
  ///   The property value for 'ExpYear'.
  /// </value>
  public short ExpYear { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
