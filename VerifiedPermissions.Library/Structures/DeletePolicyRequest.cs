using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the DeletePolicy operation.")]
public struct DeletePolicyRequest
{
    [OSStructureField(Description = "Specifies the ID of the policy that you want to delete.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyId;
    
    [OSStructureField(Description = "Specifies the ID of the policy store that contains the policy that you want to delete.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}