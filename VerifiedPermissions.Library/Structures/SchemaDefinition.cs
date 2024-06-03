using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains a list of principal types, resource types, and actions that can be specified in policies stored in the same policy store.")]
public struct SchemaDefinition
{
    [OSStructureField(
        Description =
            "A JSON string representation of the schema supported by applications that use this policy store.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string CedarJson;
}