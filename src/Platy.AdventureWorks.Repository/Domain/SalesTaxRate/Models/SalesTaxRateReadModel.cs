namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class SalesTaxRateReadModel
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
  ///   Gets or sets the property value for 'StateProvinceId'.
  /// </summary>
  /// <value>
  ///   The property value for 'StateProvinceId'.
  /// </value>
  public int StateProvinceId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TaxType'.
  /// </summary>
  /// <value>
  ///   The property value for 'TaxType'.
  /// </value>
  public byte TaxType { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TaxRate'.
  /// </summary>
  /// <value>
  ///   The property value for 'TaxRate'.
  /// </value>
  public decimal TaxRate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

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
