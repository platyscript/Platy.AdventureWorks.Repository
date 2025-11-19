namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VIndividualCustomerReadModel
  : IEntityReadModel
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
  ///   Gets or sets the property value for 'AddressType'.
  /// </summary>
  /// <value>
  ///   The property value for 'AddressType'.
  /// </value>
  public string AddressType { get; set; } = null!;

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
  ///   Gets or sets the property value for 'Demographics'.
  /// </summary>
  /// <value>
  ///   The property value for 'Demographics'.
  /// </value>
  public string? Demographics { get; set; }

  #endregion
}
