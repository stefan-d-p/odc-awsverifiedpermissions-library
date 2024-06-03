using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the GetPolicyStore operation.")]
public struct GetPolicyStoreRequest
{
    [OSStructureField(Description = "Specifies the ID of the policy store that you want information about.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}