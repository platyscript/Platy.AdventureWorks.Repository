using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Address'.
/// </summary>
[Table("Address", Schema = "Person")]
public class Address
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Address" /> class.
  /// </summary>
  public Address()
  {
    #region Generated Constructor

    BillToSalesOrderHeaders = new HashSet<SalesOrderHeader>();
    BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
    ShipToSalesOrderHeaders = new HashSet<SalesOrderHeader>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'AddressID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AddressID'.
  /// </value>
  [Key]
  [Column("AddressID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

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
  /// </value
  [Column("City", TypeName = "nvarchar(30)")]
  public string City { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceID'.
  /// </value>
  [Column("StateProvinceID", TypeName = "int")]
  public int StateProvinceId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PostalCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PostalCode'.
  /// </value>
  [Column("PostalCode", TypeName = "nvarchar(15)")]
  public string PostalCode { get; set; } = null!;

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

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </value>
  public virtual ICollection<SalesOrderHeader> BillToSalesOrderHeaders { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="BusinessEntityAddress" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="BusinessEntityAddress" />.
  /// </value>
  public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </value>
  public virtual ICollection<SalesOrderHeader> ShipToSalesOrderHeaders { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="StateProvince" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="StateProvince" />.
  /// </value>
  /// <seealso cref="StateProvinceId" />
  public virtual StateProvince StateProvince { get; set; } = null!;

  #endregion
}
