using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory" />
/// </summary>
internal class TransactionHistoryConfiguration
  : IEntityTypeConfiguration<TransactionHistory>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<TransactionHistory> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("TransactionHistory", "Production");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("TransactionID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.ProductId)
      .IsRequired()
      .HasColumnName("ProductID")
      .HasColumnType("int");

    builder.Property(t => t.ReferenceOrderId)
      .IsRequired()
      .HasColumnName("ReferenceOrderID")
      .HasColumnType("int");

    builder.Property(t => t.ReferenceOrderLineId)
      .IsRequired()
      .HasColumnName("ReferenceOrderLineID")
      .HasColumnType("int")
      .HasDefaultValue(0);

    builder.Property(t => t.TransactionDate)
      .IsRequired()
      .HasColumnName("TransactionDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    builder.Property(t => t.TransactionType)
      .IsRequired()
      .HasColumnName("TransactionType")
      .HasColumnType("nchar(1)")
      .HasMaxLength(1);

    builder.Property(t => t.Quantity)
      .IsRequired()
      .HasColumnName("Quantity")
      .HasColumnType("int");

    builder.Property(t => t.ActualCost)
      .IsRequired()
      .HasColumnName("ActualCost")
      .HasColumnType("money");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Product)
      .WithMany(t => t.TransactionHistories)
      .HasForeignKey(d => d.ProductId)
      .HasConstraintName("FK_TransactionHistory_Product_ProductID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory" />
    /// </summary>
    public const string Name = "TransactionHistory";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.Id" />
    /// </summary>
    public const string Id = "TransactionID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.ReferenceOrderId" />
    /// </summary>
    public const string ReferenceOrderId = "ReferenceOrderID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.ReferenceOrderLineId" />
    /// </summary>
    public const string ReferenceOrderLineId = "ReferenceOrderLineID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.TransactionDate" />
    /// </summary>
    public const string TransactionDate = "TransactionDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.TransactionType" />
    /// </summary>
    public const string TransactionType = "TransactionType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.Quantity" />
    /// </summary>
    public const string Quantity = "Quantity";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.ActualCost" />
    /// </summary>
    public const string ActualCost = "ActualCost";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
