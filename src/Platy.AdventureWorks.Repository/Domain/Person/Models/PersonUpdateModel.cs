namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class PersonUpdateModel
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
  ///   Gets or sets the property value for 'PersonType'.
  /// </summary>
  /// <value>
  ///   The property value for 'PersonType'.
  /// </value>
  public string PersonType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'NameStyle'.
  /// </summary>
  /// <value>
  ///   The property value for 'NameStyle'.
  /// </value>
  public bool NameStyle { get; set; }

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
  ///   Gets or sets the property value for 'EmailPromotion'.
  /// </summary>
  /// <value>
  ///   The property value for 'EmailPromotion'.
  /// </value>
  public int EmailPromotion { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'AdditionalContactInfo'.
  /// </summary>
  /// <value>
  ///   The property value for 'AdditionalContactInfo'.
  /// </value>
  public string? AdditionalContactInfo { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Demographics'.
  /// </summary>
  /// <value>
  ///   The property value for 'Demographics'.
  /// </value>
  public string? Demographics { get; set; }

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
