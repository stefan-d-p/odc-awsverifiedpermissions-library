using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the DeletePolicyStore operation.")]
public struct DeletePolicyStoreRequest
{
    [OSStructureField(Description = "Specifies the ID of the policy store that you want to delete.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}