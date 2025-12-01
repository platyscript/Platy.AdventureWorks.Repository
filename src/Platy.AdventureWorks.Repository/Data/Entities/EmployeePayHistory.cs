using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'EmployeePayHistory'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("EmployeePayHistory", Schema = "HumanResources")]
public partial class EmployeePayHistory
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeePayHistory"/> class.
    /// </summary>
    public EmployeePayHistory()
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
    /// Gets or sets the property value representing column 'RateChangeDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'RateChangeDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("RateChangeDate", TypeName = "datetime")]
    public DateTime RateChangeDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Rate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Rate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Rate", TypeName = "money")]
    public decimal Rate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PayFrequency'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PayFrequency'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PayFrequency", TypeName = "tinyint")]
    public byte PayFrequency { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="Employee" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Employee" />.
    /// </value>
    /// <seealso cref="BusinessEntityId" />
    public virtual Employee Employee { get; set; } = null!;

    #endregion

}
