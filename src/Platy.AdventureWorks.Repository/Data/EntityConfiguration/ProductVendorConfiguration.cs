using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor" />
/// </summary>
internal class ProductVendorConfiguration
  : IEntityTypeConfiguration<ProductVendor>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<ProductVendor> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("ProductVendor", "Purchasing");

    // key
    builder.HasKey(t => new { t.ProductId, t.BusinessEntityId });

    // properties
    builder.Property(t => t.ProductId)
      .IsRequired()
      .HasColumnName("ProductID")
      .HasColumnType("int");

    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.AverageLeadTime)
      .IsRequired()
      .HasColumnName("AverageLeadTime")
      .HasColumnType("int");

    builder.Property(t => t.StandardPrice)
      .IsRequired()
      .HasColumnName("StandardPrice")
      .HasColumnType("money");

    builder.Property(t => t.LastReceiptCost)
      .HasColumnName("LastReceiptCost")
      .HasColumnType("money");

    builder.Property(t => t.LastReceiptDate)
      .HasColumnName("LastReceiptDate")
      .HasColumnType("datetime");

    builder.Property(t => t.MinOrderQty)
      .IsRequired()
      .HasColumnName("MinOrderQty")
      .HasColumnType("int");

    builder.Property(t => t.MaxOrderQty)
      .IsRequired()
      .HasColumnName("MaxOrderQty")
      .HasColumnType("int");

    builder.Property(t => t.OnOrderQty)
      .HasColumnName("OnOrderQty")
      .HasColumnType("int");

    builder.Property(t => t.UnitMeasureCode)
      .IsRequired()
      .HasColumnName("UnitMeasureCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Product)
      .WithMany(t => t.ProductVendors)
      .HasForeignKey(d => d.ProductId)
      .HasConstraintName("FK_ProductVendor_Product_ProductID");

    builder.HasOne(t => t.UnitMeasure)
      .WithMany(t => t.ProductVendors)
      .HasForeignKey(d => d.UnitMeasureCode)
      .HasConstraintName("FK_ProductVendor_UnitMeasure_UnitMeasureCode");

    builder.HasOne(t => t.Vendor)
      .WithMany(t => t.ProductVendors)
      .HasForeignKey(d => d.BusinessEntityId)
      .HasConstraintName("FK_ProductVendor_Vendor_BusinessEntityID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor" />
    /// </summary>
    public const string Schema = "Purchasing";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor" />
    /// </summary>
    public const string Name = "ProductVendor";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.AverageLeadTime" />
    /// </summary>
    public const string AverageLeadTime = "AverageLeadTime";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.StandardPrice" />
    /// </summary>
    public const string StandardPrice = "StandardPrice";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.LastReceiptCost" />
    /// </summary>
    public const string LastReceiptCost = "LastReceiptCost";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.LastReceiptDate" />
    /// </summary>
    public const string LastReceiptDate = "LastReceiptDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.MinOrderQty" />
    /// </summary>
    public const string MinOrderQty = "MinOrderQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.MaxOrderQty" />
    /// </summary>
    public const string MaxOrderQty = "MaxOrderQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.OnOrderQty" />
    /// </summary>
    public const string OnOrderQty = "OnOrderQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.UnitMeasureCode" />
    /// </summary>
    public const string UnitMeasureCode = "UnitMeasureCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
