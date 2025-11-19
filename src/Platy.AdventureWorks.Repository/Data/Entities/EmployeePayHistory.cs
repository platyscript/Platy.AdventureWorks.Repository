using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'EmployeePayHistory'.
/// </summary>
[Table("EmployeePayHistory", Schema = "HumanResources")]
public class EmployeePayHistory
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmployeePayHistory" /> class.
  /// </summary>
  public EmployeePayHistory()
  {
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Employee" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Employee" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Employee Employee { get; set; } = null!;

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
  ///   Gets or sets the property value representing column 'RateChangeDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'RateChangeDate'.
  /// </value>
  [Key]
  [Column("RateChangeDate", TypeName = "datetime")]
  public DateTime RateChangeDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Rate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Rate'.
  /// </value>
  [Column("Rate", TypeName = "money")]
  public decimal Rate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PayFrequency'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PayFrequency'.
  /// </value>
  [Column("PayFrequency", TypeName = "tinyint")]
  public byte PayFrequency { get; set; }

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
