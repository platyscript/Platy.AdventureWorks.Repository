using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vAdditionalContactInfo'.
/// </summary>
[Table("vAdditionalContactInfo", Schema = "Person")]
public class VAdditionalContactInfo
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VAdditionalContactInfo" /> class.
  /// </summary>
  public VAdditionalContactInfo()
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
  ///   Gets or sets the property value representing column 'TelephoneNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TelephoneNumber'.
  /// </value>
  [Column("TelephoneNumber", TypeName = "nvarchar(50)")]
  public string? TelephoneNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TelephoneSpecialInstructions'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TelephoneSpecialInstructions'.
  /// </value>
  [Column("TelephoneSpecialInstructions", TypeName = "nvarchar(max)")]
  public string? TelephoneSpecialInstructions { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Street'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Street'.
  /// </value>
  [Column("Street", TypeName = "nvarchar(50)")]
  public string? Street { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'City'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'City'.
  /// </value>
  [Column("City", TypeName = "nvarchar(50)")]
  public string? City { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvince'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvince'.
  /// </value>
  [Column("StateProvince", TypeName = "nvarchar(50)")]
  public string? StateProvince { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PostalCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PostalCode'.
  /// </value>
  [Column("PostalCode", TypeName = "nvarchar(50)")]
  public string? PostalCode { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CountryRegion'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CountryRegion'.
  /// </value>
  [Column("CountryRegion", TypeName = "nvarchar(50)")]
  public string? CountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'HomeAddressSpecialInstructions'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'HomeAddressSpecialInstructions'.
  /// </value>
  [Column("HomeAddressSpecialInstructions", TypeName = "nvarchar(max)")]
  public string? HomeAddressSpecialInstructions { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EMailAddress'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EMailAddress'.
  /// </value>
  [Column("EMailAddress", TypeName = "nvarchar(128)")]
  public string? EMailAddress { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EMailSpecialInstructions'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EMailSpecialInstructions'.
  /// </value>
  [Column("EMailSpecialInstructions", TypeName = "nvarchar(max)")]
  public string? EMailSpecialInstructions { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EMailTelephoneNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EMailTelephoneNumber'.
  /// </value>
  [Column("EMailTelephoneNumber", TypeName = "nvarchar(50)")]
  public string? EMailTelephoneNumber { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'rowguid'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'rowguid'.
  /// </value>
  [Column("rowguid", TypeName = "uniqueidentifier")]
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ModifiedDate'.
  /// </value>
  [Column("ModifiedDate", TypeName = "datetime")]
  public DateTime ModifiedDate { get; set; }

  #endregion
}
