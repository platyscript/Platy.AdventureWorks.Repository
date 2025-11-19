using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate" />
/// </summary>
internal class CurrencyRateConfiguration
  : IEntityTypeConfiguration<CurrencyRate>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<CurrencyRate> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("CurrencyRate", "Sales");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("CurrencyRateID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.CurrencyRateDate)
      .IsRequired()
      .HasColumnName("CurrencyRateDate")
      .HasColumnType("datetime");

    builder.Property(t => t.FromCurrencyCode)
      .IsRequired()
      .HasColumnName("FromCurrencyCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.ToCurrencyCode)
      .IsRequired()
      .HasColumnName("ToCurrencyCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.AverageRate)
      .IsRequired()
      .HasColumnName("AverageRate")
      .HasColumnType("money");

    builder.Property(t => t.EndOfDayRate)
      .IsRequired()
      .HasColumnName("EndOfDayRate")
      .HasColumnType("money");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.FromCurrency)
      .WithMany(t => t.FromCurrencyRates)
      .HasForeignKey(d => d.FromCurrencyCode)
      .HasConstraintName("FK_CurrencyRate_Currency_FromCurrencyCode");

    builder.HasOne(t => t.ToCurrency)
      .WithMany(t => t.ToCurrencyRates)
      .HasForeignKey(d => d.ToCurrencyCode)
      .HasConstraintName("FK_CurrencyRate_Currency_ToCurrencyCode");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate" />
    /// </summary>
    public const string Name = "CurrencyRate";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate.Id" />
    /// </summary>
    public const string Id = "CurrencyRateID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate.CurrencyRateDate" />
    /// </summary>
    public const string CurrencyRateDate = "CurrencyRateDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate.FromCurrencyCode" />
    /// </summary>
    public const string FromCurrencyCode = "FromCurrencyCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate.ToCurrencyCode" />
    /// </summary>
    public const string ToCurrencyCode = "ToCurrencyCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate.AverageRate" />
    /// </summary>
    public const string AverageRate = "AverageRate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate.EndOfDayRate" />
    /// </summary>
    public const string EndOfDayRate = "EndOfDayRate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
