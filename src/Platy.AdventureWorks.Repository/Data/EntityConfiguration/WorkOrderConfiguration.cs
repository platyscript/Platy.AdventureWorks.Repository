using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder" />
/// </summary>
internal class WorkOrderConfiguration
  : IEntityTypeConfiguration<WorkOrder>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<WorkOrder> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("WorkOrder", "Production");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("WorkOrderID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.ProductId)
      .IsRequired()
      .HasColumnName("ProductID")
      .HasColumnType("int");

    builder.Property(t => t.OrderQty)
      .IsRequired()
      .HasColumnName("OrderQty")
      .HasColumnType("int");

    builder.Property(t => t.StockedQty)
      .IsRequired()
      .HasColumnName("StockedQty")
      .HasColumnType("int")
      .ValueGeneratedOnAddOrUpdate();

    builder.Property(t => t.ScrappedQty)
      .IsRequired()
      .HasColumnName("ScrappedQty")
      .HasColumnType("smallint");

    builder.Property(t => t.StartDate)
      .IsRequired()
      .HasColumnName("StartDate")
      .HasColumnType("datetime");

    builder.Property(t => t.EndDate)
      .HasColumnName("EndDate")
      .HasColumnType("datetime");

    builder.Property(t => t.DueDate)
      .IsRequired()
      .HasColumnName("DueDate")
      .HasColumnType("datetime");

    builder.Property(t => t.ScrapReasonId)
      .HasColumnName("ScrapReasonID")
      .HasColumnType("smallint");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Product)
      .WithMany(t => t.WorkOrders)
      .HasForeignKey(d => d.ProductId)
      .HasConstraintName("FK_WorkOrder_Product_ProductID");

    builder.HasOne(t => t.ScrapReason)
      .WithMany(t => t.WorkOrders)
      .HasForeignKey(d => d.ScrapReasonId)
      .HasConstraintName("FK_WorkOrder_ScrapReason_ScrapReasonID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder" />
    /// </summary>
    public const string Name = "WorkOrder";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.Id" />
    /// </summary>
    public const string Id = "WorkOrderID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.OrderQty" />
    /// </summary>
    public const string OrderQty = "OrderQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.StockedQty" />
    /// </summary>
    public const string StockedQty = "StockedQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.ScrappedQty" />
    /// </summary>
    public const string ScrappedQty = "ScrappedQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.StartDate" />
    /// </summary>
    public const string StartDate = "StartDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.EndDate" />
    /// </summary>
    public const string EndDate = "EndDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.DueDate" />
    /// </summary>
    public const string DueDate = "DueDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.ScrapReasonId" />
    /// </summary>
    public const string ScrapReasonId = "ScrapReasonID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
