using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the GetSchema operation.")]
public struct GetSchemaResponse
{
    [OSStructureField(Description = "The date and time that the schema was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The date and time that the schema was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;

    [OSStructureField(Description = "The namespaces of the entities referenced by this schema.",
        DataType = OSDataType.InferredFromDotNetType)]
    public List<string> Namespaces;
    
    [OSStructureField(Description = "The ID of the policy store that contains the schema.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The body of the schema, written in Cedar schema JSON.",
        DataType = OSDataType.Text)]
    public string Schema;
}