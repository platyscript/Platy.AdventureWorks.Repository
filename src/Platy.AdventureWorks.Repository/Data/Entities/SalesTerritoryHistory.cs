using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesTerritoryHistory'.
/// </summary>
[Table("SalesTerritoryHistory", Schema = "Sales")]
public class SalesTerritoryHistory
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTerritoryHistory" /> class.
  /// </summary>
  public SalesTerritoryHistory()
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
  ///   Gets or sets the property value representing column 'TerritoryID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TerritoryID'.
  /// </value>
  [Key]
  [Column("TerritoryID", TypeName = "int")]
  public int TerritoryId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StartDate'.
  /// </value>
  [Key]
  [Column("StartDate", TypeName = "datetime")]
  public DateTime StartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EndDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EndDate'.
  /// </value>
  [Column("EndDate", TypeName = "datetime")]
  public DateTime? EndDate { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="SalesPerson" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesPerson" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual SalesPerson SalesPerson { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="SalesTerritory" />.
  /// </value>
  /// <seealso cref="TerritoryId" />
  public virtual SalesTerritory SalesTerritory { get; set; } = null!;

  #endregion
}
