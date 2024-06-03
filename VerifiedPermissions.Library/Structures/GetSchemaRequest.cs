using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the GetSchema operation.")]
public struct GetSchemaRequest
{
    [OSStructureField(Description = "Specifies the ID of the policy store that contains the schema.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}