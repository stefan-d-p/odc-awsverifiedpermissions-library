using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the UpdatePolicy operation.")]
public struct UpdatePolicyRequest
{
    [OSStructureField(
        Description = "Specifies the updated policy content that you want to replace on the specified policy.",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = true)]
    public UpdatePolicyDefinition Definition;
    
    [OSStructureField(Description = "Specifies the ID of the policy that you want to update.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyId;
    
    [OSStructureField(Description = "Specifies the ID of the policy store that contains the policy that you want to update.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}