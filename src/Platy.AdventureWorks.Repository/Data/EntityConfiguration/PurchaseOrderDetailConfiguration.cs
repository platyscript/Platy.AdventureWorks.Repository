using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail" />
/// </summary>
internal class PurchaseOrderDetailConfiguration
  : IEntityTypeConfiguration<PurchaseOrderDetail>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<PurchaseOrderDetail> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("PurchaseOrderDetail", "Purchasing");

    // key
    builder.HasKey(t => new { t.PurchaseOrderId, t.Id });

    // properties
    builder.Property(t => t.PurchaseOrderId)
      .IsRequired()
      .HasColumnName("PurchaseOrderID")
      .HasColumnType("int");

    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("PurchaseOrderDetailID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.DueDate)
      .IsRequired()
      .HasColumnName("DueDate")
      .HasColumnType("datetime");

    builder.Property(t => t.OrderQty)
      .IsRequired()
      .HasColumnName("OrderQty")
      .HasColumnType("smallint");

    builder.Property(t => t.ProductId)
      .IsRequired()
      .HasColumnName("ProductID")
      .HasColumnType("int");

    builder.Property(t => t.UnitPrice)
      .IsRequired()
      .HasColumnName("UnitPrice")
      .HasColumnType("money");

    builder.Property(t => t.LineTotal)
      .IsRequired()
      .HasColumnName("LineTotal")
      .HasColumnType("money")
      .ValueGeneratedOnAddOrUpdate();

    builder.Property(t => t.ReceivedQty)
      .IsRequired()
      .HasColumnName("ReceivedQty")
      .HasColumnType("decimal(8,2)");

    builder.Property(t => t.RejectedQty)
      .IsRequired()
      .HasColumnName("RejectedQty")
      .HasColumnType("decimal(8,2)");

    builder.Property(t => t.StockedQty)
      .IsRequired()
      .HasColumnName("StockedQty")
      .HasColumnType("decimal(9,2)")
      .ValueGeneratedOnAddOrUpdate();

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Product)
      .WithMany(t => t.PurchaseOrderDetails)
      .HasForeignKey(d => d.ProductId)
      .HasConstraintName("FK_PurchaseOrderDetail_Product_ProductID");

    builder.HasOne(t => t.PurchaseOrderHeader)
      .WithMany(t => t.PurchaseOrderDetails)
      .HasForeignKey(d => d.PurchaseOrderId)
      .HasConstraintName("FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail" />
    /// </summary>
    public const string Schema = "Purchasing";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail" />
    /// </summary>
    public const string Name = "PurchaseOrderDetail";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.PurchaseOrderId" />
    /// </summary>
    public const string PurchaseOrderId = "PurchaseOrderID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.Id" />
    /// </summary>
    public const string Id = "PurchaseOrderDetailID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.DueDate" />
    /// </summary>
    public const string DueDate = "DueDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.OrderQty" />
    /// </summary>
    public const string OrderQty = "OrderQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.UnitPrice" />
    /// </summary>
    public const string UnitPrice = "UnitPrice";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.LineTotal" />
    /// </summary>
    public const string LineTotal = "LineTotal";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.ReceivedQty" />
    /// </summary>
    public const string ReceivedQty = "ReceivedQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.RejectedQty" />
    /// </summary>
    public const string RejectedQty = "RejectedQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.StockedQty" />
    /// </summary>
    public const string StockedQty = "StockedQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
