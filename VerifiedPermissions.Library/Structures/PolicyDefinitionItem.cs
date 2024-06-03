using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "A structure that describes a Policy Definition item")]
public struct PolicyDefinitionItem
{
    [OSStructureField(Description = "Information about a static policy that wasn't created with a policy template.",
        DataType = OSDataType.InferredFromDotNetType)]
    public StaticPolicyDefinitionItem Static;
    
    [OSStructureField(Description = "Information about a template-linked policy that was created by instantiating a policy template.",
        DataType = OSDataType.InferredFromDotNetType)]
    public TemplateLinkedPolicyDefinitionItem Template;
}