using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive" />
/// </summary>
internal class TransactionHistoryArchiveConfiguration
  : IEntityTypeConfiguration<TransactionHistoryArchive>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<TransactionHistoryArchive> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("TransactionHistoryArchive", "Production");

    // key
    builder.HasKey(t => t.TransactionId);

    // properties
    builder.Property(t => t.TransactionId)
      .IsRequired()
      .HasColumnName("TransactionID")
      .HasColumnType("int");

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

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive" />
    /// </summary>
    public const string Name = "TransactionHistoryArchive";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.TransactionId" />
    /// </summary>
    public const string TransactionId = "TransactionID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.ReferenceOrderId" />
    /// </summary>
    public const string ReferenceOrderId = "ReferenceOrderID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.ReferenceOrderLineId" />
    /// </summary>
    public const string ReferenceOrderLineId = "ReferenceOrderLineID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.TransactionDate" />
    /// </summary>
    public const string TransactionDate = "TransactionDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.TransactionType" />
    /// </summary>
    public const string TransactionType = "TransactionType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.Quantity" />
    /// </summary>
    public const string Quantity = "Quantity";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.ActualCost" />
    /// </summary>
    public const string ActualCost = "ActualCost";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
