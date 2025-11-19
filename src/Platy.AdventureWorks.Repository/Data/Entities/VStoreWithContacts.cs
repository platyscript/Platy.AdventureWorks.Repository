using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vStoreWithContacts'.
/// </summary>
[Table("vStoreWithContacts", Schema = "Sales")]
public class VStoreWithContacts
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VStoreWithContacts" /> class.
  /// </summary>
  public VStoreWithContacts()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Column("BusinessEntityID", TypeName = "int")]
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'ContactType'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ContactType'.
  /// </value>
  [Column("ContactType", TypeName = "nvarchar(50)")]
  public string ContactType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Title'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Title'.
  /// </value>
  [Column("Title", TypeName = "nvarchar(8)")]
  public string? Title { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'FirstName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'FirstName'.
  /// </value>
  [Column("FirstName", TypeName = "nvarchar(50)")]
  public string FirstName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'MiddleName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MiddleName'.
  /// </value>
  [Column("MiddleName", TypeName = "nvarchar(50)")]
  public string? MiddleName { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LastName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LastName'.
  /// </value>
  [Column("LastName", TypeName = "nvarchar(50)")]
  public string LastName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Suffix'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Suffix'.
  /// </value>
  [Column("Suffix", TypeName = "nvarchar(10)")]
  public string? Suffix { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PhoneNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PhoneNumber'.
  /// </value>
  [Column("PhoneNumber", TypeName = "nvarchar(25)")]
  public string? PhoneNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PhoneNumberType'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PhoneNumberType'.
  /// </value>
  [Column("PhoneNumberType", TypeName = "nvarchar(50)")]
  public string? PhoneNumberType { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EmailAddress'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EmailAddress'.
  /// </value>
  [Column("EmailAddress", TypeName = "nvarchar(50)")]
  public string? EmailAddress { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EmailPromotion'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EmailPromotion'.
  /// </value>
  [Column("EmailPromotion", TypeName = "int")]
  public int EmailPromotion { get; set; }

  #endregion
}
