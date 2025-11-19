using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesPerson'.
/// </summary>
[Table("SalesPerson", Schema = "Sales")]
public class SalesPerson
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesPerson" /> class.
  /// </summary>
  public SalesPerson()
  {
    #region Generated Constructor

    SalesOrderHeaders = new HashSet<SalesOrderHeader>();
    SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
    SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
    Stores = new HashSet<Store>();

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
  ///   Gets or sets the property value representing column 'TerritoryID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TerritoryID'.
  /// </value>
  [Column("TerritoryID", TypeName = "int")]
  public int? TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesQuota'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesQuota'.
  /// </value>
  [Column("SalesQuota", TypeName = "money")]
  public decimal? SalesQuota { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Bonus'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Bonus'.
  /// </value>
  [Column("Bonus", TypeName = "money")]
  public decimal Bonus { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CommissionPct'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CommissionPct'.
  /// </value>
  [Column("CommissionPct", TypeName = "smallmoney")]
  public decimal CommissionPct { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesYTD'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesYTD'.
  /// </value>
  [Column("SalesYTD", TypeName = "money")]
  public decimal SalesYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesLastYear'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesLastYear'.
  /// </value>
  [Column("SalesLastYear", TypeName = "money")]
  public decimal SalesLastYear { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="Employee" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Employee" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Employee Employee { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </value>
  public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesPersonQuotaHistory" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesPersonQuotaHistory" />.
  /// </value>
  public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesTerritory" />.
  /// </value>
  /// <seealso cref="TerritoryId" />
  public virtual SalesTerritory? SalesTerritory { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesTerritoryHistory" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesTerritoryHistory" />.
  /// </value>
  public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="Store" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="Store" />.
  /// </value>
  public virtual ICollection<Store> Stores { get; set; }

  #endregion
}
