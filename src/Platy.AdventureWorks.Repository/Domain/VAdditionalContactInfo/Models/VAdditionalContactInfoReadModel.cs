namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VAdditionalContactInfoReadModel
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
  ///   Gets or sets the property value for 'TelephoneNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'TelephoneNumber'.
  /// </value>
  public string? TelephoneNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'TelephoneSpecialInstructions'.
  /// </summary>
  /// <value>
  ///   The property value for 'TelephoneSpecialInstructions'.
  /// </value>
  public string? TelephoneSpecialInstructions { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Street'.
  /// </summary>
  /// <value>
  ///   The property value for 'Street'.
  /// </value>
  public string? Street { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'City'.
  /// </summary>
  /// <value>
  ///   The property value for 'City'.
  /// </value>
  public string? City { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'StateProvince'.
  /// </summary>
  /// <value>
  ///   The property value for 'StateProvince'.
  /// </value>
  public string? StateProvince { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'PostalCode'.
  /// </summary>
  /// <value>
  ///   The property value for 'PostalCode'.
  /// </value>
  public string? PostalCode { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CountryRegion'.
  /// </summary>
  /// <value>
  ///   The property value for 'CountryRegion'.
  /// </value>
  public string? CountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'HomeAddressSpecialInstructions'.
  /// </summary>
  /// <value>
  ///   The property value for 'HomeAddressSpecialInstructions'.
  /// </value>
  public string? HomeAddressSpecialInstructions { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EMailAddress'.
  /// </summary>
  /// <value>
  ///   The property value for 'EMailAddress'.
  /// </value>
  public string? EMailAddress { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EMailSpecialInstructions'.
  /// </summary>
  /// <value>
  ///   The property value for 'EMailSpecialInstructions'.
  /// </value>
  public string? EMailSpecialInstructions { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EMailTelephoneNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'EMailTelephoneNumber'.
  /// </value>
  public string? EMailTelephoneNumber { get; set; }

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
