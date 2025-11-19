using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesTerritory'.
/// </summary>
[Table("SalesTerritory", Schema = "Sales")]
public class SalesTerritory
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTerritory" /> class.
  /// </summary>
  public SalesTerritory()
  {
    #region Generated Constructor

    Customers = new HashSet<Customer>();
    SalesOrderHeaders = new HashSet<SalesOrderHeader>();
    SalesPeople = new HashSet<SalesPerson>();
    SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
    StateProvinces = new HashSet<StateProvince>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'TerritoryID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TerritoryID'.
  /// </value>
  [Key]
  [Column("TerritoryID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'CountryRegionCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CountryRegionCode'.
  /// </value>
  [Column("CountryRegionCode", TypeName = "nvarchar(3)")]
  public string CountryRegionCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Group'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Group'.
  /// </value>
  [Column("Group", TypeName = "nvarchar(50)")]
  public string Group { get; set; } = null!;

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
  ///   Gets or sets the property value representing column 'CostYTD'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CostYTD'.
  /// </value>
  [Column("CostYTD", TypeName = "money")]
  public decimal CostYTD { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'CostLastYear'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'CostLastYear'.
  /// </value>
  [Column("CostLastYear", TypeName = "money")]
  public decimal CostLastYear { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="CountryRegion" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="CountryRegion" />.
  /// </value>
  /// <seealso cref="CountryRegionCode" />
  public virtual CountryRegion CountryRegion { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="Customer" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="Customer" />.
  /// </value>
  public virtual ICollection<Customer> Customers { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderHeader" />.
  /// </value>
  public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesPerson" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesPerson" />.
  /// </value>
  public virtual ICollection<SalesPerson> SalesPeople { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesTerritoryHistory" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesTerritoryHistory" />.
  /// </value>
  public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="StateProvince" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="StateProvince" />.
  /// </value>
  public virtual ICollection<StateProvince> StateProvinces { get; set; }

  #endregion
}
