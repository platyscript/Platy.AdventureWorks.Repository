using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vSalesPerson'.
/// </summary>
[Table("vSalesPerson", Schema = "Sales")]
public class VSalesPerson
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VSalesPerson" /> class.
  /// </summary>
  public VSalesPerson()
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
  ///   Gets or sets the property value representing column 'JobTitle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'JobTitle'.
  /// </value>
  [Column("JobTitle", TypeName = "nvarchar(50)")]
  public string JobTitle { get; set; } = null!;

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

  /// <summary>
  ///   Gets or sets the property value representing column 'AddressLine1'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AddressLine1'.
  /// </value>
  [Column("AddressLine1", TypeName = "nvarchar(60)")]
  public string AddressLine1 { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'AddressLine2'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AddressLine2'.
  /// </value>
  [Column("AddressLine2", TypeName = "nvarchar(60)")]
  public string? AddressLine2 { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'City'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'City'.
  /// </value>
  [Column("City", TypeName = "nvarchar(30)")]
  public string City { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceName'.
  /// </value>
  [Column("StateProvinceName", TypeName = "nvarchar(50)")]
  public string StateProvinceName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'PostalCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PostalCode'.
  /// </value>
  [Column("PostalCode", TypeName = "nvarchar(15)")]
  public string PostalCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'CountryRegionName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CountryRegionName'.
  /// </value>
  [Column("CountryRegionName", TypeName = "nvarchar(50)")]
  public string CountryRegionName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'TerritoryName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TerritoryName'.
  /// </value>
  [Column("TerritoryName", TypeName = "nvarchar(50)")]
  public string? TerritoryName { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TerritoryGroup'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TerritoryGroup'.
  /// </value>
  [Column("TerritoryGroup", TypeName = "nvarchar(50)")]
  public string? TerritoryGroup { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesQuota'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesQuota'.
  /// </value>
  [Column("SalesQuota", TypeName = "money")]
  public decimal? SalesQuota { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesYTD'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesYTD'.
  /// </value>
  [Column("SalesYTD", TypeName = "money")]
  public decimal SalesYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesLastYear'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesLastYear'.
  /// </value>
  [Column("SalesLastYear", TypeName = "money")]
  public decimal SalesLastYear { get; set; }

  #endregion
}
