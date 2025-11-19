using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Department'.
/// </summary>
[Table("Department", Schema = "HumanResources")]
public class Department
  : HasDomainEventsBase, IIdentity<short>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Department" /> class.
  /// </summary>
  public Department()
  {
    #region Generated Constructor

    EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

    #endregion
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
  /// </value>
  public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'DepartmentID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'DepartmentID'.
  /// </value>
  [Key]
  [Column("DepartmentID", TypeName = "smallint")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public short Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'GroupName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'GroupName'.
  /// </value>
  [Column("GroupName", TypeName = "nvarchar(50)")]
  public string GroupName { get; set; } = null!;

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
