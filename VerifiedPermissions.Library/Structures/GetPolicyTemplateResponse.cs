using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the GetPolicyTemplate operation.")]
public struct GetPolicyTemplateResponse
{
    [OSStructureField(Description = "The date and time that the policy template was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The description of the policy template.",
        DataType = OSDataType.Text)]
    public string Description;
    
    [OSStructureField(Description = "The date and time that the policy template was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;
    
    [OSStructureField(Description = "The ID of the policy store that contains the policy template.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The ID of the policy template.",
        DataType = OSDataType.Text)]
    public string PolicyTemplateId;

    [OSStructureField(
        Description = "The content of the body of the policy template written in the Cedar policy language.",
        DataType = OSDataType.Text)]
    public string Statement;
    
}