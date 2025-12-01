using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'Shift'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("Shift", Schema = "HumanResources")]
public partial class Shift
    : HasDomainEventsBase, IIdentity<byte>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Shift"/> class.
    /// </summary>
    public Shift()
    {
        #region Generated Constructor
        EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ShiftID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ShiftID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ShiftID", TypeName = "tinyint")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name", TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'StartTime'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StartTime'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StartTime", TypeName = "time")]
    public TimeOnly StartTime { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EndTime'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EndTime'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EndTime", TypeName = "time")]
    public TimeOnly EndTime { get; set; }

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
