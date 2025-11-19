public string WriteCode()
{
    CodeBuilder.Clear();

    CodeBuilder.Append("ModelClass: ").Append(Model.ModelClass.ToSafeName()).AppendLine();
    CodeBuilder.Append("ModelType: ").Append(Model.ModelType.ToString()).AppendLine();
    CodeBuilder.Append("ModelNamespace: '").Append(Model.ModelNamespace.ToSafeName()).AppendLine("'");
    CodeBuilder.Append("ModelBaseClass: ").Append(Model.ModelBaseClass.ToSafeName()).AppendLine();
    CodeBuilder.Append("ValidatorNamespace: '").Append(Model.ValidatorNamespace.ToSafeName()).AppendLine("'");
    CodeBuilder.Append("ValidatorClass: ").Append(Model.ValidatorClass.ToSafeName()).AppendLine();
    CodeBuilder.Append("ValidatorBaseClass: ").Append(Model.ValidatorBaseClass.ToSafeName()).AppendLine();

    CodeBuilder.Append("Properties:").AppendLine();
    using (CodeBuilder.Indent())
        GenerateProperties();

    return CodeBuilder.ToString();
}

private void GenerateProperties()
{
    foreach (var property in Model.Properties)
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
