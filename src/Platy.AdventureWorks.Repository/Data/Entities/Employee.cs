using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Employee'.
/// </summary>
[Table("Employee", Schema = "HumanResources")]
public class Employee
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Employee" /> class.
  /// </summary>
  public Employee()
  {
    #region Generated Constructor

    EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
    EmployeePayHistories = new HashSet<EmployeePayHistory>();
    JobCandidates = new HashSet<JobCandidate>();
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
  ///   Gets or sets the property value representing column 'NationalIDNumber'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'NationalIDNumber'.
  /// </value>
  [Column("NationalIDNumber", TypeName = "nvarchar(15)")]
  public string NationalIdNumber { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'LoginID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LoginID'.
  /// </value>
  [Column("LoginID", TypeName = "nvarchar(256)")]
  public string LoginId { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'OrganizationLevel'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'OrganizationLevel'.
  /// </value>
  [Column("OrganizationLevel", TypeName = "smallint")]
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public short? OrganizationLevel { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'JobTitle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'JobTitle'.
  /// </value>
  [Column("JobTitle", TypeName = "nvarchar(50)")]
  public string JobTitle { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'BirthDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BirthDate'.
  /// </value>
  [Column("BirthDate", TypeName = "date")]
  public DateOnly BirthDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'MaritalStatus'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MaritalStatus'.
  /// </value>
  [Column("MaritalStatus", TypeName = "nchar(1)")]
  public string MaritalStatus { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Gender'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Gender'.
  /// </value>
  [Column("Gender", TypeName = "nchar(1)")]
  public string Gender { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'HireDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'HireDate'.
  /// </value>
  [Column("HireDate", TypeName = "date")]
  public DateOnly HireDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalariedFlag'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalariedFlag'.
  /// </value>
  [Column("SalariedFlag", TypeName = "bit")]
  public bool SalariedFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'VacationHours'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'VacationHours'.
  /// </value>
  [Column("VacationHours", TypeName = "smallint")]
  public short VacationHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SickLeaveHours'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SickLeaveHours'.
  /// </value>
  [Column("SickLeaveHours", TypeName = "smallint")]
  public short SickLeaveHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CurrentFlag'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CurrentFlag'.
  /// </value>
  [Column("CurrentFlag", TypeName = "bit")]
  public bool CurrentFlag { get; set; }

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
  ///   Gets or sets the navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
  /// </value>
  public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="EmployeePayHistory" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="EmployeePayHistory" />.
  /// </value>
  public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="JobCandidate" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="JobCandidate" />.
  /// </value>
  public virtual ICollection<JobCandidate> JobCandidates { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Person" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Person" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Person Person { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="PurchaseOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="PurchaseOrderHeader" />.
  /// </value>
  public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesPerson" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesPerson" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual SalesPerson SalesPerson { get; set; } = null!;

  #endregion
}
