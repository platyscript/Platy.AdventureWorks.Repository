using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person" />
/// </summary>
internal class PersonConfiguration
  : IEntityTypeConfiguration<Person>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<Person> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("Person", "Person");

    // key
    builder.HasKey(t => t.BusinessEntityId);

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.PersonType)
      .IsRequired()
      .HasColumnName("PersonType")
      .HasColumnType("nchar(2)")
      .HasMaxLength(2);

    builder.Property(t => t.NameStyle)
      .IsRequired()
      .HasColumnName("NameStyle")
      .HasColumnType("bit")
      .HasDefaultValue(false);

    builder.Property(t => t.Title)
      .HasColumnName("Title")
      .HasColumnType("nvarchar(8)")
      .HasMaxLength(8);

    builder.Property(t => t.FirstName)
      .IsRequired()
      .HasColumnName("FirstName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.MiddleName)
      .HasColumnName("MiddleName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.LastName)
      .IsRequired()
      .HasColumnName("LastName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.Suffix)
      .HasColumnName("Suffix")
      .HasColumnType("nvarchar(10)")
      .HasMaxLength(10);

    builder.Property(t => t.EmailPromotion)
      .IsRequired()
      .HasColumnName("EmailPromotion")
      .HasColumnType("int")
      .HasDefaultValue(0);

    builder.Property(t => t.AdditionalContactInfo)
      .HasColumnName("AdditionalContactInfo")
      .HasColumnType("xml");

    builder.Property(t => t.Demographics)
      .HasColumnName("Demographics")
      .HasColumnType("xml");

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
    builder.HasOne(t => t.BusinessEntity)
      .WithOne(t => t.Person)
      .HasForeignKey<Person>(d => d.BusinessEntityId)
      .HasConstraintName("FK_Person_BusinessEntity_BusinessEntityID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person" />
    /// </summary>
    public const string Schema = "Person";

    /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person" /></summary>
    public const string Name = "Person";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.PersonType" />
    /// </summary>
    public const string PersonType = "PersonType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.NameStyle" />
    /// </summary>
    public const string NameStyle = "NameStyle";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.Title" />
    /// </summary>
    public const string Title = "Title";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.FirstName" />
    /// </summary>
    public const string FirstName = "FirstName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.MiddleName" />
    /// </summary>
    public const string MiddleName = "MiddleName";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.LastName" />
    /// </summary>
    public const string LastName = "LastName";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.Suffix" />
    /// </summary>
    public const string Suffix = "Suffix";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.EmailPromotion" />
    /// </summary>
    public const string EmailPromotion = "EmailPromotion";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.AdditionalContactInfo" />
    /// </summary>
    public const string AdditionalContactInfo = "AdditionalContactInfo";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.Demographics" />
    /// </summary>
    public const string Demographics = "Demographics";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
