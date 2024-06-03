using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the DeletePolicyTemplate operation")]
public struct DeletePolicyTemplateRequest
{
    [OSStructureField(Description = "Specifies the ID of the policy store that contains the policy template that you want to delete.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "Specifies the ID of the policy template that you want to delete.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyTemplateId;
}