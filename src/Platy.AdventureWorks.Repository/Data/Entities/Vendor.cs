using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Vendor'.
/// </summary>
[Table("Vendor", Schema = "Purchasing")]
public class Vendor
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Vendor" /> class.
  /// </summary>
  public Vendor()
  {
    #region Generated Constructor

    ProductVendors = new HashSet<ProductVendor>();
    PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Key]
  [Column("BusinessEntityID", TypeName = "int")]
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'AccountNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AccountNumber'.
  /// </value>
  [Column("AccountNumber", TypeName = "nvarchar(15)")]
  public string AccountNumber { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'CreditRating'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CreditRating'.
  /// </value>
  [Column("CreditRating", TypeName = "tinyint")]
  public byte CreditRating { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PreferredVendorStatus'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PreferredVendorStatus'.
  /// </value>
  [Column("PreferredVendorStatus", TypeName = "bit")]
  public bool PreferredVendorStatus { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ActiveFlag'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ActiveFlag'.
  /// </value>
  [Column("ActiveFlag", TypeName = "bit")]
  public bool ActiveFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PurchasingWebServiceURL'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PurchasingWebServiceURL'.
  /// </value>
  [Column("PurchasingWebServiceURL", TypeName = "nvarchar(1024)")]
  public string? PurchasingWebServiceURL { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="BusinessEntity" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual BusinessEntity BusinessEntity { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="ProductVendor" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="ProductVendor" />.
  /// </value>
  public virtual ICollection<ProductVendor> ProductVendors { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="PurchaseOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="PurchaseOrderHeader" />.
  /// </value>
  public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

  #endregion
}
