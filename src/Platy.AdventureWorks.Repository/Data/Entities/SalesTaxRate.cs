using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesTaxRate'.
/// </summary>
[Table("SalesTaxRate", Schema = "Sales")]
public class SalesTaxRate
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTaxRate" /> class.
  /// </summary>
  public SalesTaxRate()
  {
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="StateProvince" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="StateProvince" />.
  /// </value>
  /// <seealso cref="StateProvinceId" />
  public virtual StateProvince StateProvince { get; set; } = null!;

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesTaxRateID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesTaxRateID'.
  /// </value>
  [Key]
  [Column("SalesTaxRateID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'StateProvinceID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'StateProvinceID'.
  /// </value>
  [Column("StateProvinceID", TypeName = "int")]
  public int StateProvinceId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TaxType'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TaxType'.
  /// </value>
  [Column("TaxType", TypeName = "tinyint")]
  public byte TaxType { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TaxRate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TaxRate'.
  /// </value>
  [Column("TaxRate", TypeName = "smallmoney")]
  public decimal TaxRate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

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
}
