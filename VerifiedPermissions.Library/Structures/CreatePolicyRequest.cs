using System.Data.Common;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Creates a Cedar policy and saves it in the specified policy store")]
public struct CreatePolicyRequest
{
    [OSStructureField(
        Description = "Specifies a unique, case-sensitive ID that you provide to ensure the idempotency of the request",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? ClientToken;

    [OSStructureField(Description = "A structure that specifies the policy type and content to use for the new policy",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = true)]
    public PolicyDefinition Definition;
    
    [OSStructureField(Description = "Specifies the <c>PolicyStoreId</c> of the policy store you want to store the policy in.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
    


}