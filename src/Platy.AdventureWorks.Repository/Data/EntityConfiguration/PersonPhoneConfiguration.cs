using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone" />
/// </summary>
internal class PersonPhoneConfiguration
  : IEntityTypeConfiguration<PersonPhone>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<PersonPhone> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("PersonPhone", "Person");

    // key
    builder.HasKey(t => new { t.BusinessEntityId, t.PhoneNumber, t.PhoneNumberTypeId });

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.PhoneNumber)
      .IsRequired()
      .HasColumnName("PhoneNumber")
      .HasColumnType("nvarchar(25)")
      .HasMaxLength(25);

    builder.Property(t => t.PhoneNumberTypeId)
      .IsRequired()
      .HasColumnName("PhoneNumberTypeID")
      .HasColumnType("int");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Person)
      .WithMany(t => t.PersonPhones)
      .HasForeignKey(d => d.BusinessEntityId)
      .HasConstraintName("FK_PersonPhone_Person_BusinessEntityID");

    builder.HasOne(t => t.PhoneNumberType)
      .WithMany(t => t.PersonPhones)
      .HasForeignKey(d => d.PhoneNumberTypeId)
      .HasConstraintName("FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone" />
    /// </summary>
    public const string Schema = "Person";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone" />
    /// </summary>
    public const string Name = "PersonPhone";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone.PhoneNumber" />
    /// </summary>
    public const string PhoneNumber = "PhoneNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone.PhoneNumberTypeId" />
    /// </summary>
    public const string PhoneNumberTypeId = "PhoneNumberTypeID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
