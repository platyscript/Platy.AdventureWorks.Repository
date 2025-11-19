using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'PersonCreditCard'.
/// </summary>
[Table("PersonCreditCard", Schema = "Sales")]
public class PersonCreditCard
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonCreditCard" /> class.
  /// </summary>
  public PersonCreditCard()
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
  ///   Gets or sets the property value representing column 'CreditCardID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CreditCardID'.
  /// </value>
  [Key]
  [Column("CreditCardID", TypeName = "int")]
  public int CreditCardId { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="CreditCard" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="CreditCard" />.
  /// </value>
  /// <seealso cref="CreditCardId" />
  public virtual CreditCard CreditCard { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Person" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Person" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Person Person { get; set; } = null!;

  #endregion
}
