using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard" />
/// </summary>
internal class CreditCardConfiguration
  : IEntityTypeConfiguration<CreditCard>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<CreditCard> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("CreditCard", "Sales");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("CreditCardID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.CardType)
      .IsRequired()
      .HasColumnName("CardType")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.CardNumber)
      .IsRequired()
      .HasColumnName("CardNumber")
      .HasColumnType("nvarchar(25)")
      .HasMaxLength(25);

    builder.Property(t => t.ExpMonth)
      .IsRequired()
      .HasColumnName("ExpMonth")
      .HasColumnType("tinyint");

    builder.Property(t => t.ExpYear)
      .IsRequired()
      .HasColumnName("ExpYear")
      .HasColumnType("smallint");

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
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard" />
    /// </summary>
    public const string Name = "CreditCard";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard.Id" />
    /// </summary>
    public const string Id = "CreditCardID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard.CardType" />
    /// </summary>
    public const string CardType = "CardType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard.CardNumber" />
    /// </summary>
    public const string CardNumber = "CardNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard.ExpMonth" />
    /// </summary>
    public const string ExpMonth = "ExpMonth";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard.ExpYear" />
    /// </summary>
    public const string ExpYear = "ExpYear";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
