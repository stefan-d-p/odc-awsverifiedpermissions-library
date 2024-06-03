using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains details about a policy template")]
public struct PolicyTemplateItem
{
    [OSStructureField(Description = "The date and time that the policy template was created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The description attached to the policy template.",
        DataType = OSDataType.Text)]
    public string Description;
    
    [OSStructureField(Description = "The date and time that the policy template was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;
    
    [OSStructureField(Description = "The unique identifier of the policy store that contains the template.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The unique identifier of the policy template.",
        DataType = OSDataType.Text)]
    public string PolicyTemplateId;
}