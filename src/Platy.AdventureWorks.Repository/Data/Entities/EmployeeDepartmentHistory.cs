using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'EmployeeDepartmentHistory'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("EmployeeDepartmentHistory", Schema = "HumanResources")]
public partial class EmployeeDepartmentHistory
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeDepartmentHistory"/> class.
    /// </summary>
    public EmployeeDepartmentHistory()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'BusinessEntityID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BusinessEntityID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("BusinessEntityID", TypeName = "int")]
    public int BusinessEntityId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'DepartmentID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'DepartmentID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("DepartmentID", TypeName = "smallint")]
    public short DepartmentId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ShiftID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ShiftID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ShiftID", TypeName = "tinyint")]
    public byte ShiftId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StartDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StartDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("StartDate", TypeName = "date")]
    public DateOnly StartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EndDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EndDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EndDate", TypeName = "date")]
    public DateOnly? EndDate { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="Department" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Department" />.
    /// </value>
    /// <seealso cref="DepartmentId" />
    public virtual Department Department { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Employee" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Employee" />.
    /// </value>
    /// <seealso cref="BusinessEntityId" />
    public virtual Employee Employee { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Shift" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Shift" />.
    /// </value>
    /// <seealso cref="ShiftId" />
    public virtual Shift Shift { get; set; } = null!;

    #endregion

}
