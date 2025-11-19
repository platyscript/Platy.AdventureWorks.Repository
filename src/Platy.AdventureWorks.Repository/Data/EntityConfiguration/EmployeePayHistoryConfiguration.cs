using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory" />
/// </summary>
internal class EmployeePayHistoryConfiguration
  : IEntityTypeConfiguration<EmployeePayHistory>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<EmployeePayHistory> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("EmployeePayHistory", "HumanResources");

    // key
    builder.HasKey(t => new { t.BusinessEntityId, t.RateChangeDate });

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.RateChangeDate)
      .IsRequired()
      .HasColumnName("RateChangeDate")
      .HasColumnType("datetime");

    builder.Property(t => t.Rate)
      .IsRequired()
      .HasColumnName("Rate")
      .HasColumnType("money");

    builder.Property(t => t.PayFrequency)
      .IsRequired()
      .HasColumnName("PayFrequency")
      .HasColumnType("tinyint");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Employee)
      .WithMany(t => t.EmployeePayHistories)
      .HasForeignKey(d => d.BusinessEntityId)
      .HasConstraintName("FK_EmployeePayHistory_Employee_BusinessEntityID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory" />
    /// </summary>
    public const string Schema = "HumanResources";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory" />
    /// </summary>
    public const string Name = "EmployeePayHistory";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory.RateChangeDate" />
    /// </summary>
    public const string RateChangeDate = "RateChangeDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory.Rate" />
    /// </summary>
    public const string Rate = "Rate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory.PayFrequency" />
    /// </summary>
    public const string PayFrequency = "PayFrequency";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
