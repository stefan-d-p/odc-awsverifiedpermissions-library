using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the PutSchema operation.")]
public struct PutSchemaRequest
{
    [OSStructureField(Description = "Specifies the definition of the schema to be stored.",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = true)]
    public SchemaDefinition Definition;
    
    [OSStructureField(Description = "Specifies the ID of the policy store in which to place the schema.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}