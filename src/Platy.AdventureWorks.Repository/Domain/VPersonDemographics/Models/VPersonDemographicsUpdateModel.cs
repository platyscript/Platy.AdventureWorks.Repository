namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VPersonDemographicsUpdateModel
  : IEntityUpdateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'BusinessEntityId'.
  /// </summary>
  /// <value>
  ///   The property value for 'BusinessEntityId'.
  /// </value>
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TotalPurchaseYTD'.
  /// </summary>
  /// <value>
  ///   The property value for 'TotalPurchaseYTD'.
  /// </value>
  public decimal? TotalPurchaseYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'DateFirstPurchase'.
  /// </summary>
  /// <value>
  ///   The property value for 'DateFirstPurchase'.
  /// </value>
  public DateTime? DateFirstPurchase { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'BirthDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'BirthDate'.
  /// </value>
  public DateTime? BirthDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'MaritalStatus'.
  /// </summary>
  /// <value>
  ///   The property value for 'MaritalStatus'.
  /// </value>
  public string? MaritalStatus { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'YearlyIncome'.
  /// </summary>
  /// <value>
  ///   The property value for 'YearlyIncome'.
  /// </value>
  public string? YearlyIncome { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Gender'.
  /// </summary>
  /// <value>
  ///   The property value for 'Gender'.
  /// </value>
  public string? Gender { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TotalChildren'.
  /// </summary>
  /// <value>
  ///   The property value for 'TotalChildren'.
  /// </value>
  public int? TotalChildren { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'NumberChildrenAtHome'.
  /// </summary>
  /// <value>
  ///   The property value for 'NumberChildrenAtHome'.
  /// </value>
  public int? NumberChildrenAtHome { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Education'.
  /// </summary>
  /// <value>
  ///   The property value for 'Education'.
  /// </value>
  public string? Education { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Occupation'.
  /// </summary>
  /// <value>
  ///   The property value for 'Occupation'.
  /// </value>
  public string? Occupation { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'HomeOwnerFlag'.
  /// </summary>
  /// <value>
  ///   The property value for 'HomeOwnerFlag'.
  /// </value>
  public bool? HomeOwnerFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'NumberCarsOwned'.
  /// </summary>
  /// <value>
  ///   The property value for 'NumberCarsOwned'.
  /// </value>
  public int? NumberCarsOwned { get; set; }

  #endregion
}
