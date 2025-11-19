namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VSalesPersonCreateModel
  : IEntityCreateModel
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
  ///   Gets or sets the property value for 'Title'.
  /// </summary>
  /// <value>
  ///   The property value for 'Title'.
  /// </value>
  public string? Title { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'FirstName'.
  /// </summary>
  /// <value>
  ///   The property value for 'FirstName'.
  /// </value>
  public string FirstName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'MiddleName'.
  /// </summary>
  /// <value>
  ///   The property value for 'MiddleName'.
  /// </value>
  public string? MiddleName { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'LastName'.
  /// </summary>
  /// <value>
  ///   The property value for 'LastName'.
  /// </value>
  public string LastName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Suffix'.
  /// </summary>
  /// <value>
  ///   The property value for 'Suffix'.
  /// </value>
  public string? Suffix { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'JobTitle'.
  /// </summary>
  /// <value>
  ///   The property value for 'JobTitle'.
  /// </value>
  public string JobTitle { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'PhoneNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'PhoneNumber'.
  /// </value>
  public string? PhoneNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'PhoneNumberType'.
  /// </summary>
  /// <value>
  ///   The property value for 'PhoneNumberType'.
  /// </value>
  public string? PhoneNumberType { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EmailAddress'.
  /// </summary>
  /// <value>
  ///   The property value for 'EmailAddress'.
  /// </value>
  public string? EmailAddress { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EmailPromotion'.
  /// </summary>
  /// <value>
  ///   The property value for 'EmailPromotion'.
  /// </value>
  public int EmailPromotion { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'AddressLine1'.
  /// </summary>
  /// <value>
  ///   The property value for 'AddressLine1'.
  /// </value>
  public string AddressLine1 { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'AddressLine2'.
  /// </summary>
  /// <value>
  ///   The property value for 'AddressLine2'.
  /// </value>
  public string? AddressLine2 { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'City'.
  /// </summary>
  /// <value>
  ///   The property value for 'City'.
  /// </value>
  public string City { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'StateProvinceName'.
  /// </summary>
  /// <value>
  ///   The property value for 'StateProvinceName'.
  /// </value>
  public string StateProvinceName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'PostalCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'PostalCode'.
  /// </value>
  public string PostalCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'CountryRegionName'.
  /// </summary>
  /// <value>
  ///   The property value for 'CountryRegionName'.
  /// </value>
  public string CountryRegionName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'TerritoryName'.
  /// </summary>
  /// <value>
  ///   The property value for 'TerritoryName'.
  /// </value>
  public string? TerritoryName { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TerritoryGroup'.
  /// </summary>
  /// <value>
  ///   The property value for 'TerritoryGroup'.
  /// </value>
  public string? TerritoryGroup { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesQuota'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesQuota'.
  /// </value>
  public decimal? SalesQuota { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesYTD'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesYTD'.
  /// </value>
  public decimal SalesYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalesLastYear'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalesLastYear'.
  /// </value>
  public decimal SalesLastYear { get; set; }

  #endregion
}
