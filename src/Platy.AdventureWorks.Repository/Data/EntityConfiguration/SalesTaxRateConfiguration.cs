using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate" />
/// </summary>
internal class SalesTaxRateConfiguration
  : IEntityTypeConfiguration<SalesTaxRate>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<SalesTaxRate> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("SalesTaxRate", "Sales");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("SalesTaxRateID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.StateProvinceId)
      .IsRequired()
      .HasColumnName("StateProvinceID")
      .HasColumnType("int");

    builder.Property(t => t.TaxType)
      .IsRequired()
      .HasColumnName("TaxType")
      .HasColumnType("tinyint");

    builder.Property(t => t.TaxRate)
      .IsRequired()
      .HasColumnName("TaxRate")
      .HasColumnType("smallmoney")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.Rowguid)
      .IsRequired()
      .HasColumnName("rowguid")
      .HasColumnType("uniqueidentifier")
      .HasDefaultValueSql("(newid())");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.StateProvince)
      .WithMany(t => t.SalesTaxRates)
      .HasForeignKey(d => d.StateProvinceId)
      .HasConstraintName("FK_SalesTaxRate_StateProvince_StateProvinceID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate" />
    /// </summary>
    public const string Name = "SalesTaxRate";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate.Id" />
    /// </summary>
    public const string Id = "SalesTaxRateID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate.StateProvinceId" />
    /// </summary>
    public const string StateProvinceId = "StateProvinceID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate.TaxType" />
    /// </summary>
    public const string TaxType = "TaxType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate.TaxRate" />
    /// </summary>
    public const string TaxRate = "TaxRate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
