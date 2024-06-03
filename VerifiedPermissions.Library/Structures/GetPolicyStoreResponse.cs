using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the GetPolicyStore operation.")]
public struct GetPolicyStoreResponse
{
    [OSStructureField(Description = "The Amazon Resource Name (ARN) of the policy store.",
        DataType = OSDataType.Text)]
    public string Arn;

    [OSStructureField(Description = "The date and time that the policy store was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "Descriptive text that you can provide to help with identification of the current policy store.",
        DataType = OSDataType.Text)]
    public string Description;
    
    [OSStructureField(Description = "The date and time that the policy store was last updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;
    
    [OSStructureField(Description = "The ID of the policy store",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The current validation settings for the policy store.",
        DataType = OSDataType.Text)]
    public string ValidationSettings;
}