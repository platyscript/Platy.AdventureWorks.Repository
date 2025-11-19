using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Store'.
/// </summary>
[Table("Store", Schema = "Sales")]
public class Store
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Store" /> class.
  /// </summary>
  public Store()
  {
    #region Generated Constructor

    Customers = new HashSet<Customer>();

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
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesPersonID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesPersonID'.
  /// </value>
  [Column("SalesPersonID", TypeName = "int")]
  public int? SalesPersonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Demographics'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Demographics'.
  /// </value>
  [Column("Demographics", TypeName = "xml")]
  public string? Demographics { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="BusinessEntity" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual BusinessEntity BusinessEntity { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="Customer" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="Customer" />.
  /// </value>
  public virtual ICollection<Customer> Customers { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesPerson" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesPerson" />.
  /// </value>
  /// <seealso cref="SalesPersonId" />
  public virtual SalesPerson? SalesPerson { get; set; }

  #endregion
}
