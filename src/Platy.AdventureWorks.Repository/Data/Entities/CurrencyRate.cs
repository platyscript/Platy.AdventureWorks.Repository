using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'CurrencyRate'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("CurrencyRate", Schema = "Sales")]
public partial class CurrencyRate
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyRate"/> class.
    /// </summary>
    public CurrencyRate()
    {
        #region Generated Constructor
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'CurrencyRateID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CurrencyRateID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("CurrencyRateID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'CurrencyRateDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CurrencyRateDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CurrencyRateDate", TypeName = "datetime")]
    public DateTime CurrencyRateDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'FromCurrencyCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'FromCurrencyCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("FromCurrencyCode", TypeName = "nchar(3)")]
    public string FromCurrencyCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'ToCurrencyCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ToCurrencyCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ToCurrencyCode", TypeName = "nchar(3)")]
    public string ToCurrencyCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'AverageRate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AverageRate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AverageRate", TypeName = "money")]
    public decimal AverageRate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EndOfDayRate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EndOfDayRate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EndOfDayRate", TypeName = "money")]
    public decimal EndOfDayRate { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="Currency" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Currency" />.
    /// </value>
    /// <seealso cref="FromCurrencyCode" />
    public virtual Currency FromCurrency { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="SalesOrderHeader" />.
    /// </value>
    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Currency" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Currency" />.
    /// </value>
    /// <seealso cref="ToCurrencyCode" />
    public virtual Currency ToCurrency { get; set; } = null!;

    #endregion

}
