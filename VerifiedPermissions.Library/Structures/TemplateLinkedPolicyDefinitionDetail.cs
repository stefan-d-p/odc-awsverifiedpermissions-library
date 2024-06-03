using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains information about a policy that was created by instantiating a policy template")]
public struct TemplateLinkedPolicyDefinitionDetail
{
    [OSStructureField(Description = "The unique identifier of the policy template used to create this policy",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyTemplateId;
    
    [OSStructureField(Description = "The principal associated with this template-linked policy",
        DataType = OSDataType.InferredFromDotNetType)]
    public EntityIdentifier Principal;
    
    [OSStructureField(Description = "The resource associated with this template-linked policy",
        DataType = OSDataType.InferredFromDotNetType)]
    public EntityIdentifier Resource;
}