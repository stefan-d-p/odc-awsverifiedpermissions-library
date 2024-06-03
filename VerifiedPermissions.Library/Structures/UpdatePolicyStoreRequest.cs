using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the UpdatePolicyStore operation.")]
public struct UpdatePolicyStoreRequest
{
    [OSStructureField(Description = "Descriptive text that you can provide to help with identification of the current policy store.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? Description;
    
    [OSStructureField(Description = "Specifies the ID of the policy store that you want to update.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "A structure that defines the validation settings that want to enable for the policy store.",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = true)]
    public ValidationSettings ValidationSettings;
}