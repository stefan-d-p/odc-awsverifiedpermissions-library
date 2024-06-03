using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the CreatePolicyTemplate operation.")]
public struct CreatePolicyTemplateResponse
{
    [OSStructureField(Description = "The date and time the policy template was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The date and time the policy template was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;

    [OSStructureField(Description = "The ID of the policy store that contains the policy template.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The unique ID of the new policy template.",
        DataType = OSDataType.Text)]
    public string PolicyTemplateId;
}