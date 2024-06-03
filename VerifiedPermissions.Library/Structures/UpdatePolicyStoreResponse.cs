using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the UpdatePolicyStore operation.")]
public struct UpdatePolicyStoreResponse
{
    [OSStructureField(Description = "The Amazon Resource Name (ARN) of the updated policy store",
        DataType = OSDataType.Text)]
    public string Arn;

    [OSStructureField(Description = "The date and time that the policy store was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The date and time that the policy store was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;

    [OSStructureField(Description = "The ID of the updated policy store.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
}