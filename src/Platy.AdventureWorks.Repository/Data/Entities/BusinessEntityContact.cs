using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'BusinessEntityContact'.
/// </summary>
[Table("BusinessEntityContact", Schema = "Person")]
public class BusinessEntityContact
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntityContact" /> class.
  /// </summary>
  public BusinessEntityContact()
  {
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
  ///   Gets or sets the property value representing column 'PersonID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PersonID'.
  /// </value>
  [Key]
  [Column("PersonID", TypeName = "int")]
  public int PersonId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ContactTypeID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ContactTypeID'.
  /// </value>
  [Key]
  [Column("ContactTypeID", TypeName = "int")]
  public int ContactTypeId { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="ContactType" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="ContactType" />.
  /// </value>
  /// <seealso cref="ContactTypeId" />
  public virtual ContactType ContactType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Person" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Person" />.
  /// </value>
  /// <seealso cref="PersonId" />
  public virtual Person Person { get; set; } = null!;

  #endregion
}
