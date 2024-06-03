using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains information about updates to be applied to a policy.")]
public struct UpdatePolicyDefinition
{
    [OSStructureField(Description = "Contains details about the updates to be applied to a static policy.",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = true)]
    public UpdateStaticPolicyDefinition Static;
}