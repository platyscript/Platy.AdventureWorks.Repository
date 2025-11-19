using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'BusinessEntity'.
/// </summary>
[Table("BusinessEntity", Schema = "Person")]
public class BusinessEntity
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntity" /> class.
  /// </summary>
  public BusinessEntity()
  {
    #region Generated Constructor

    BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
    BusinessEntityContacts = new HashSet<BusinessEntityContact>();

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
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

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
  ///   Gets or sets the navigation collection for entity <see cref="BusinessEntityAddress" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="BusinessEntityAddress" />.
  /// </value>
  public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="BusinessEntityContact" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="BusinessEntityContact" />.
  /// </value>
  public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Person" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Person" />.
  /// </value>
  /// <seealso cref="Id" />
  public virtual Person Person { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Store" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Store" />.
  /// </value>
  /// <seealso cref="Id" />
  public virtual Store Store { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Vendor" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Vendor" />.
  /// </value>
  /// <seealso cref="Id" />
  public virtual Vendor Vendor { get; set; } = null!;

  #endregion
}
