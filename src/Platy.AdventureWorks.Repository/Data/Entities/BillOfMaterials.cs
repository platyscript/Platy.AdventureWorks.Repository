using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'BillOfMaterials'.
/// </summary>
[Table("BillOfMaterials", Schema = "Production")]
public class BillOfMaterials
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BillOfMaterials" /> class.
  /// </summary>
  public BillOfMaterials()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'BillOfMaterialsID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BillOfMaterialsID'.
  /// </value>
  [Key]
  [Column("BillOfMaterialsID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductAssemblyID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductAssemblyID'.
  /// </value>
  [Column("ProductAssemblyID", TypeName = "int")]
  public int? ProductAssemblyId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ComponentID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ComponentID'.
  /// </value>
  [Column("ComponentID", TypeName = "int")]
  public int ComponentId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StartDate'.
  /// </value>
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
  ///   Gets or sets the property value representing column 'UnitMeasureCode'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'UnitMeasureCode'.
  /// </value>
  [Column("UnitMeasureCode", TypeName = "nchar(3)")]
  public string UnitMeasureCode { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'BOMLevel'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BOMLevel'.
  /// </value>
  [Column("BOMLevel", TypeName = "smallint")]
  public short BOMLevel { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PerAssemblyQty'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PerAssemblyQty'.
  /// </value>
  [Column("PerAssemblyQty", TypeName = "decimal(8,2)")]
  public decimal PerAssemblyQty { get; set; }

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
  ///   Gets or sets the navigation property for entity <see cref="Product" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Product" />.
  /// </value>
  /// <seealso cref="ProductAssemblyId" />
  public virtual Product? AssemblyProduct { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Product" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Product" />.
  /// </value>
  /// <seealso cref="ComponentId" />
  public virtual Product ComponentProduct { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="UnitMeasure" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="UnitMeasure" />.
  /// </value>
  /// <seealso cref="UnitMeasureCode" />
  public virtual UnitMeasure UnitMeasure { get; set; } = null!;

  #endregion
}
