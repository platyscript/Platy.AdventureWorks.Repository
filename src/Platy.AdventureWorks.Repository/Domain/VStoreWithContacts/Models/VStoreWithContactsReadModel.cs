namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class VStoreWithContactsReadModel
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
  ///   Gets or sets the property value for 'Name'.
  /// </summary>
  /// <value>
  ///   The property value for 'Name'.
  /// </value>
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'ContactType'.
  /// </summary>
  /// <value>
  ///   The property value for 'ContactType'.
  /// </value>
  public string ContactType { get; set; } = null!;

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

  #endregion
}
