using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory" />
/// </summary>
internal class ProductCategoryConfiguration
  : IEntityTypeConfiguration<ProductCategory>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<ProductCategory> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("ProductCategory", "Production");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("ProductCategoryID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

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
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory" />
    /// </summary>
    public const string Name = "ProductCategory";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory.Id" />
    /// </summary>
    public const string Id = "ProductCategoryID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
