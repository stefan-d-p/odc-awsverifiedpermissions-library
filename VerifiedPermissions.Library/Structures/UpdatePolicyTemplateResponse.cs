using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the UpdatePolicyTemplate operation.")]
public struct UpdatePolicyTemplateResponse
{
    [OSStructureField(Description = "The date and time that the policy template was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The date and time that the policy template was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;
    
    [OSStructureField(Description = "The ID of the policy store that contains the updated policy template.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The ID of the updated policy template.",
        DataType = OSDataType.Text)]
    public string PolicyTemplateId;
}