using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'EmailAddress'.
/// </summary>
[Table("EmailAddress", Schema = "Person")]
public class EmailAddress
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmailAddress" /> class.
  /// </summary>
  public EmailAddress()
  {
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Person" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Person" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Person Person { get; set; } = null!;

  #endregion

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
  ///   Gets or sets the property value representing column 'EmailAddressID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EmailAddressID'.
  /// </value>
  [Key]
  [Column("EmailAddressID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EmailAddress'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EmailAddress'.
  /// </value>
  [Column("EmailAddress", TypeName = "nvarchar(50)")]
  public string? EmailAddressMember { get; set; }

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
