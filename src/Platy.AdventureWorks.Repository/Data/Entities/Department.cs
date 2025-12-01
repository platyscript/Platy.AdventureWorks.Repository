using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'Department'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("Department", Schema = "HumanResources")]
public partial class Department
    : HasDomainEventsBase, IIdentity<short>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Department"/> class.
    /// </summary>
    public Department()
    {
        #region Generated Constructor
        EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'DepartmentID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'DepartmentID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("DepartmentID", TypeName = "smallint")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public short Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name", TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'GroupName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'GroupName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("GroupName", TypeName = "nvarchar(50)")]
    public string GroupName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ModifiedDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ModifiedDate", TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
    /// </value>
    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    #endregion

}
