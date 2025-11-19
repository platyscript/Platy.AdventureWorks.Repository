namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class CustomerCreateModel
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
  ///   Gets or sets the property value for 'PersonId'.
  /// </summary>
  /// <value>
  ///   The property value for 'PersonId'.
  /// </value>
  public int? PersonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'StoreId'.
  /// </summary>
  /// <value>
  ///   The property value for 'StoreId'.
  /// </value>
  public int? StoreId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TerritoryId'.
  /// </summary>
  /// <value>
  ///   The property value for 'TerritoryId'.
  /// </value>
  public int? TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'AccountNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'AccountNumber'.
  /// </value>
  public string AccountNumber { get; set; } = null!;

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
