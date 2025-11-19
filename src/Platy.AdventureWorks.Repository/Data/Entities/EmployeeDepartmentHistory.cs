using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'EmployeeDepartmentHistory'.
/// </summary>
[Table("EmployeeDepartmentHistory", Schema = "HumanResources")]
public class EmployeeDepartmentHistory
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmployeeDepartmentHistory" /> class.
  /// </summary>
  public EmployeeDepartmentHistory()
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
  ///   Gets or sets the property value representing column 'DepartmentID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'DepartmentID'.
  /// </value>
  [Key]
  [Column("DepartmentID", TypeName = "smallint")]
  public short DepartmentId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ShiftID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ShiftID'.
  /// </value>
  [Key]
  [Column("ShiftID", TypeName = "tinyint")]
  public byte ShiftId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StartDate'.
  /// </value>
  [Key]
  [Column("StartDate", TypeName = "date")]
  public DateOnly StartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EndDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EndDate'.
  /// </value>
  [Column("EndDate", TypeName = "date")]
  public DateOnly? EndDate { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="Department" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Department" />.
  /// </value>
  /// <seealso cref="DepartmentId" />
  public virtual Department Department { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Employee" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Employee" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Employee Employee { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Shift" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Shift" />.
  /// </value>
  /// <seealso cref="ShiftId" />
  public virtual Shift Shift { get; set; } = null!;

  #endregion
}
