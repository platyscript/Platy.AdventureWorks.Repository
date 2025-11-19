namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class PersonPhoneCreateModel
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
  ///   Gets or sets the property value for 'PhoneNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'PhoneNumber'.
  /// </value>
  public string PhoneNumber { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'PhoneNumberTypeId'.
  /// </summary>
  /// <value>
  ///   The property value for 'PhoneNumberTypeId'.
  /// </value>
  public int PhoneNumberTypeId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
