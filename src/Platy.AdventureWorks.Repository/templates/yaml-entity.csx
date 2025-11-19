public string WriteCode()
{
    CodeBuilder.Clear();

    CodeBuilder.Append("EntityClass: ").Append(Entity.EntityClass.ToSafeName()).AppendLine();
    CodeBuilder.Append("EntityNamespace: '").Append(Entity.EntityNamespace.ToSafeName()).AppendLine("'");
    CodeBuilder.Append("EntityBaseClass: ").Append(TemplateOptions.BaseClass).AppendLine();
    CodeBuilder.Append("TableNaming: ").Append(GeneratorOptions.Database.TableNaming.ToString()).AppendLine();


    CodeBuilder.Append("ContextProperty: ").Append(Entity.ContextProperty.ToSafeName()).AppendLine();

    CodeBuilder.Append("TableSchema: '").Append(Entity.TableSchema.ToSafeName()).AppendLine("'");
    CodeBuilder.Append("TableName: '").Append(Entity.TableName.ToSafeName()).AppendLine("'");


    CodeBuilder.Append("MappingClass: ").Append(Entity.MappingClass.ToSafeName()).AppendLine();
    CodeBuilder.Append("MappingNamespace: '").Append(Entity.MappingNamespace.ToSafeName()).AppendLine("'");

    CodeBuilder.Append("MapperClass: ").Append(Entity.MapperClass.ToSafeName()).AppendLine();
    CodeBuilder.Append("MapperNamespace: '").Append(Entity.MapperClass.ToSafeName()).AppendLine("'");
    CodeBuilder.Append("MapperBaseClass: ").Append(Entity.MapperBaseClass.ToSafeName()).AppendLine();

    CodeBuilder.Append("IsView: ").Append(Entity.IsView.ToString()).AppendLine();

    CodeBuilder.Append("Properties:").AppendLine();
    using (CodeBuilder.Indent())
        GenerateProperties();

    return CodeBuilder.ToString();
}

private void GenerateProperties()
{
    foreach (var property in Entity.Properties)
    {
        CodeBuilder.Append("- PropertyName: ").Append(property.PropertyName.ToSafeName()).AppendLine();
        CodeBuilder.Append("  ColumnName: '").Append(property.ColumnName.ToSafeName()).AppendLine("'");
        CodeBuilder.Append("  StoreType: ").Append(property.StoreType.ToSafeName()).AppendLine();
        CodeBuilder.Append("  NativeType: '").Append(property.NativeType.ToSafeName()).AppendLine("'");
        CodeBuilder.Append("  DataType: ").Append(property.DataType.ToString()).AppendLine();
        CodeBuilder.Append("  SystemType: ").Append(property.SystemType.Name).AppendLine();

        if (property.Size != null)
            CodeBuilder.Append("  Size: ").Append(property.Size.ToString()).AppendLine();

        if (property.Default != null)
            CodeBuilder.Append("  Default: '").Append(property.Default.ToSafeName()).AppendLine("'");

        if (property.ValueGenerated != null)
            CodeBuilder.Append("  ValueGenerated: ").Append(property.ValueGenerated.ToString()).AppendLine();

        if (property.IsNullable != null)
            CodeBuilder.Append("  IsNullable: ").Append(property.IsNullable.ToString()).AppendLine();

        if (property.IsPrimaryKey != null)
            CodeBuilder.Append("  IsPrimaryKey: ").Append(property.IsPrimaryKey.ToString()).AppendLine();

        if (property.IsForeignKey != null)
            CodeBuilder.Append("  IsForeignKey: ").Append(property.IsForeignKey.ToString()).AppendLine();

        if (property.IsReadOnly != null)
            CodeBuilder.Append("  IsReadOnly: ").Append(property.IsReadOnly.ToString()).AppendLine();

        if (property.IsRowVersion != null)
            CodeBuilder.Append("  IsRowVersion: ").Append(property.IsRowVersion.ToString()).AppendLine();

        if (property.IsUnique != null)
            CodeBuilder.Append("  IsUnique: ").Append(property.IsUnique.ToString()).AppendLine();
    }
}

// run script
WriteCode()
