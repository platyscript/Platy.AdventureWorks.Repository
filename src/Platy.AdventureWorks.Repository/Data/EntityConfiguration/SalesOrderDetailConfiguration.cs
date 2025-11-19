using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail" />
/// </summary>
internal class SalesOrderDetailConfiguration
  : IEntityTypeConfiguration<SalesOrderDetail>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<SalesOrderDetail> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("SalesOrderDetail", "Sales");

    // key
    builder.HasKey(t => new { t.SalesOrderId, t.Id });

    // properties
    builder.Property(t => t.SalesOrderId)
      .IsRequired()
      .HasColumnName("SalesOrderID")
      .HasColumnType("int");

    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("SalesOrderDetailID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.CarrierTrackingNumber)
      .HasColumnName("CarrierTrackingNumber")
      .HasColumnType("nvarchar(25)")
      .HasMaxLength(25);

    builder.Property(t => t.OrderQty)
      .IsRequired()
      .HasColumnName("OrderQty")
      .HasColumnType("smallint");

    builder.Property(t => t.ProductId)
      .IsRequired()
      .HasColumnName("ProductID")
      .HasColumnType("int");

    builder.Property(t => t.SpecialOfferId)
      .IsRequired()
      .HasColumnName("SpecialOfferID")
      .HasColumnType("int");

    builder.Property(t => t.UnitPrice)
      .IsRequired()
      .HasColumnName("UnitPrice")
      .HasColumnType("money");

    builder.Property(t => t.UnitPriceDiscount)
      .IsRequired()
      .HasColumnName("UnitPriceDiscount")
      .HasColumnType("money")
      .HasDefaultValueSql("((0.0))");

    builder.Property(t => t.LineTotal)
      .IsRequired()
      .HasColumnName("LineTotal")
      .HasColumnType("numeric(38,6)")
      .ValueGeneratedOnAddOrUpdate();

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
    builder.HasOne(t => t.SalesOrderHeader)
      .WithMany(t => t.SalesOrderDetails)
      .HasForeignKey(d => d.SalesOrderId)
      .HasConstraintName("FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID");

    builder.HasOne(t => t.SpecialOfferProduct)
      .WithMany(t => t.SalesOrderDetails)
      .HasForeignKey(d => new { d.SpecialOfferId, d.ProductId })
      .HasConstraintName("FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail" />
    /// </summary>
    public const string Name = "SalesOrderDetail";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.SalesOrderId" />
    /// </summary>
    public const string SalesOrderId = "SalesOrderID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.Id" />
    /// </summary>
    public const string Id = "SalesOrderDetailID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.CarrierTrackingNumber" />
    /// </summary>
    public const string CarrierTrackingNumber = "CarrierTrackingNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.OrderQty" />
    /// </summary>
    public const string OrderQty = "OrderQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.SpecialOfferId" />
    /// </summary>
    public const string SpecialOfferId = "SpecialOfferID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.UnitPrice" />
    /// </summary>
    public const string UnitPrice = "UnitPrice";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.UnitPriceDiscount" />
    /// </summary>
    public const string UnitPriceDiscount = "UnitPriceDiscount";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.LineTotal" />
    /// </summary>
    public const string LineTotal = "LineTotal";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
