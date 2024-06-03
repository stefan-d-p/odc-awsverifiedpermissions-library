using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "GetPolicy Request Parameters")]
public struct GetPolicyRequest
{
    [OSStructureField(Description = "Specifies the ID of the policy you want information about",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyId;
    
    [OSStructureField(Description = "Specifies the ID of the policy store that contains the policy that you want information about.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}