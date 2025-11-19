using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason" />
/// </summary>
internal class SalesOrderHeaderSalesReasonConfiguration
  : IEntityTypeConfiguration<SalesOrderHeaderSalesReason>
{
  /// <summary>
  ///   Configures the entity of type
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<SalesOrderHeaderSalesReason> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("SalesOrderHeaderSalesReason", "Sales");

    // key
    builder.HasKey(t => new { t.SalesOrderId, t.SalesReasonId });

    // properties
    builder.Property(t => t.SalesOrderId)
      .IsRequired()
      .HasColumnName("SalesOrderID")
      .HasColumnType("int");

    builder.Property(t => t.SalesReasonId)
      .IsRequired()
      .HasColumnName("SalesReasonID")
      .HasColumnType("int");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.SalesOrderHeader)
      .WithMany(t => t.SalesOrderHeaderSalesReasons)
      .HasForeignKey(d => d.SalesOrderId)
      .HasConstraintName("FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID");

    builder.HasOne(t => t.SalesReason)
      .WithMany(t => t.SalesOrderHeaderSalesReasons)
      .HasForeignKey(d => d.SalesReasonId)
      .HasConstraintName("FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason" />
    /// </summary>
    public const string Name = "SalesOrderHeaderSalesReason";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason.SalesOrderId" />
    /// </summary>
    public const string SalesOrderId = "SalesOrderID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason.SalesReasonId" />
    /// </summary>
    public const string SalesReasonId = "SalesReasonID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
