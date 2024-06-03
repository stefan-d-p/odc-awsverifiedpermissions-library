using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the UpdatePolicyTemplate operation.")]
public struct UpdatePolicyTemplateRequest
{
    [OSStructureField(Description = "Specifies a new description to apply to the policy template.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? Description;
    
    [OSStructureField(Description = "Specifies the ID of the policy store that contains the policy template that you want to update.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "Specifies the ID of the policy template that you want to update.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyTemplateId;
    
    [OSStructureField(Description = "Specifies new statement content written in Cedar policy language to replace the current body of the policy template.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string Statement;
}