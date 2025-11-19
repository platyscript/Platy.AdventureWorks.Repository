using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture" />
/// </summary>
internal class ProductModelProductDescriptionCultureConfiguration
  : IEntityTypeConfiguration<ProductModelProductDescriptionCulture>
{
  /// <summary>
  ///   Configures the entity of type
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<ProductModelProductDescriptionCulture> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("ProductModelProductDescriptionCulture", "Production");

    // key
    builder.HasKey(t => new { t.ProductModelId, t.ProductDescriptionId, t.CultureId });

    // properties
    builder.Property(t => t.ProductModelId)
      .IsRequired()
      .HasColumnName("ProductModelID")
      .HasColumnType("int");

    builder.Property(t => t.ProductDescriptionId)
      .IsRequired()
      .HasColumnName("ProductDescriptionID")
      .HasColumnType("int");

    builder.Property(t => t.CultureId)
      .IsRequired()
      .HasColumnName("CultureID")
      .HasColumnType("nchar(6)")
      .HasMaxLength(6);

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Culture)
      .WithMany(t => t.ProductModelProductDescriptionCultures)
      .HasForeignKey(d => d.CultureId)
      .HasConstraintName("FK_ProductModelProductDescriptionCulture_Culture_CultureID");

    builder.HasOne(t => t.ProductDescription)
      .WithMany(t => t.ProductModelProductDescriptionCultures)
      .HasForeignKey(d => d.ProductDescriptionId)
      .HasConstraintName("FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID");

    builder.HasOne(t => t.ProductModel)
      .WithMany(t => t.ProductModelProductDescriptionCultures)
      .HasForeignKey(d => d.ProductModelId)
      .HasConstraintName("FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture" />
    /// </summary>
    public const string Name = "ProductModelProductDescriptionCulture";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture.ProductModelId" />
    /// </summary>
    public const string ProductModelId = "ProductModelID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture.ProductDescriptionId" />
    /// </summary>
    public const string ProductDescriptionId = "ProductDescriptionID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture.CultureId" />
    /// </summary>
    public const string CultureId = "CultureID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
