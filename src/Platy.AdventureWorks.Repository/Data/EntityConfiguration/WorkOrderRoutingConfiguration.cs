using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting" />
/// </summary>
internal class WorkOrderRoutingConfiguration
  : IEntityTypeConfiguration<WorkOrderRouting>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<WorkOrderRouting> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("WorkOrderRouting", "Production");

    // key
    builder.HasKey(t => new { t.WorkOrderId, t.ProductId, t.OperationSequence });

    // properties
    builder.Property(t => t.WorkOrderId)
      .IsRequired()
      .HasColumnName("WorkOrderID")
      .HasColumnType("int");

    builder.Property(t => t.ProductId)
      .IsRequired()
      .HasColumnName("ProductID")
      .HasColumnType("int");

    builder.Property(t => t.OperationSequence)
      .IsRequired()
      .HasColumnName("OperationSequence")
      .HasColumnType("smallint");

    builder.Property(t => t.LocationId)
      .IsRequired()
      .HasColumnName("LocationID")
      .HasColumnType("smallint");

    builder.Property(t => t.ScheduledStartDate)
      .IsRequired()
      .HasColumnName("ScheduledStartDate")
      .HasColumnType("datetime");

    builder.Property(t => t.ScheduledEndDate)
      .IsRequired()
      .HasColumnName("ScheduledEndDate")
      .HasColumnType("datetime");

    builder.Property(t => t.ActualStartDate)
      .HasColumnName("ActualStartDate")
      .HasColumnType("datetime");

    builder.Property(t => t.ActualEndDate)
      .HasColumnName("ActualEndDate")
      .HasColumnType("datetime");

    builder.Property(t => t.ActualResourceHrs)
      .HasColumnName("ActualResourceHrs")
      .HasColumnType("decimal(9,4)");

    builder.Property(t => t.PlannedCost)
      .IsRequired()
      .HasColumnName("PlannedCost")
      .HasColumnType("money");

    builder.Property(t => t.ActualCost)
      .HasColumnName("ActualCost")
      .HasColumnType("money");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Location)
      .WithMany(t => t.WorkOrderRoutings)
      .HasForeignKey(d => d.LocationId)
      .HasConstraintName("FK_WorkOrderRouting_Location_LocationID");

    builder.HasOne(t => t.WorkOrder)
      .WithMany(t => t.WorkOrderRoutings)
      .HasForeignKey(d => d.WorkOrderId)
      .HasConstraintName("FK_WorkOrderRouting_WorkOrder_WorkOrderID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting" />
    /// </summary>
    public const string Name = "WorkOrderRouting";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.WorkOrderId" />
    /// </summary>
    public const string WorkOrderId = "WorkOrderID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.OperationSequence" />
    /// </summary>
    public const string OperationSequence = "OperationSequence";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.LocationId" />
    /// </summary>
    public const string LocationId = "LocationID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.ScheduledStartDate" />
    /// </summary>
    public const string ScheduledStartDate = "ScheduledStartDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.ScheduledEndDate" />
    /// </summary>
    public const string ScheduledEndDate = "ScheduledEndDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.ActualStartDate" />
    /// </summary>
    public const string ActualStartDate = "ActualStartDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.ActualEndDate" />
    /// </summary>
    public const string ActualEndDate = "ActualEndDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.ActualResourceHrs" />
    /// </summary>
    public const string ActualResourceHrs = "ActualResourceHrs";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.PlannedCost" />
    /// </summary>
    public const string PlannedCost = "PlannedCost";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.ActualCost" />
    /// </summary>
    public const string ActualCost = "ActualCost";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
