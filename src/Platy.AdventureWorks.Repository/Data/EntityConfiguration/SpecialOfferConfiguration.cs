using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer" />
/// </summary>
internal class SpecialOfferConfiguration
  : IEntityTypeConfiguration<SpecialOffer>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<SpecialOffer> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("SpecialOffer", "Sales");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("SpecialOfferID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.Description)
      .IsRequired()
      .HasColumnName("Description")
      .HasColumnType("nvarchar(255)")
      .HasMaxLength(255);

    builder.Property(t => t.DiscountPct)
      .IsRequired()
      .HasColumnName("DiscountPct")
      .HasColumnType("smallmoney")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.Type)
      .IsRequired()
      .HasColumnName("Type")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.Category)
      .IsRequired()
      .HasColumnName("Category")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.StartDate)
      .IsRequired()
      .HasColumnName("StartDate")
      .HasColumnType("datetime");

    builder.Property(t => t.EndDate)
      .IsRequired()
      .HasColumnName("EndDate")
      .HasColumnType("datetime");

    builder.Property(t => t.MinQty)
      .IsRequired()
      .HasColumnName("MinQty")
      .HasColumnType("int")
      .HasDefaultValue(0);

    builder.Property(t => t.MaxQty)
      .HasColumnName("MaxQty")
      .HasColumnType("int");

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

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer" />
    /// </summary>
    public const string Name = "SpecialOffer";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.Id" />
    /// </summary>
    public const string Id = "SpecialOfferID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.Description" />
    /// </summary>
    public const string Description = "Description";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.DiscountPct" />
    /// </summary>
    public const string DiscountPct = "DiscountPct";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.Type" />
    /// </summary>
    public const string Type = "Type";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.Category" />
    /// </summary>
    public const string Category = "Category";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.StartDate" />
    /// </summary>
    public const string StartDate = "StartDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.EndDate" />
    /// </summary>
    public const string EndDate = "EndDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.MinQty" />
    /// </summary>
    public const string MinQty = "MinQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.MaxQty" />
    /// </summary>
    public const string MaxQty = "MaxQty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
