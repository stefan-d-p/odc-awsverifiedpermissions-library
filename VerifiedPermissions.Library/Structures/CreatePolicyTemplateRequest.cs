using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the CreatePolicyTemplate operation.")]
public struct CreatePolicyTemplateRequest
{
    [OSStructureField(Description = "Specifies a unique, case-sensitive ID that you provide to ensure the idempotency of the request.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? ClientToken;
    
    [OSStructureField(Description = "Specifies a description for the policy template.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? Description;
    
    [OSStructureField(Description = "The ID of the policy store in which to create the policy template.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;

    [OSStructureField(
        Description =
            "Specifies the content that you want to use for the new policy template, written in the Cedar policy language.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string Statement;

}