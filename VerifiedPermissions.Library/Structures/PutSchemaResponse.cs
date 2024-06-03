using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the PutSchema operation.")]
public struct PutSchemaResponse
{
    [OSStructureField(Description = "The date and time that the schema was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The date and time that the schema was last updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;

    [OSStructureField(Description = "Identifies the namespaces of the entities referenced by this schema.",
        DataType = OSDataType.InferredFromDotNetType)]
    public List<string> Namespaces;
    
    [OSStructureField(Description = "The unique ID of the policy store that contains the schema.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;

}