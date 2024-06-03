using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the CreatePolicyStore operation.")]
public struct CreatePolicyStoreResponse
{
    [OSStructureField(Description = "The Amazon Resource Name (ARN) of the new policy store.",
        DataType = OSDataType.Text)]
    public string Arn;

    [OSStructureField(Description = "The date and time the policy store was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The date and time the policy store was last updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;

    [OSStructureField(Description = "The unique ID of the new policy store.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
}