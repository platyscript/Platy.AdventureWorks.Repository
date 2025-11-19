using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Password'.
/// </summary>
[Table("Password", Schema = "Person")]
public class Password
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Password" /> class.
  /// </summary>
  public Password()
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
  ///   Gets or sets the property value representing column 'PasswordHash'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PasswordHash'.
  /// </value>
  [Column("PasswordHash", TypeName = "varchar(128)")]
  public string PasswordHash { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'PasswordSalt'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PasswordSalt'.
  /// </value>
  [Column("PasswordSalt", TypeName = "varchar(10)")]
  public string PasswordSalt { get; set; } = null!;

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
