using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains information about an update to a static policy.")]
public struct UpdateStaticPolicyDefinition
{
    [OSStructureField(Description = "Specifies the description to be added to or replaced on the static policy.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? Description;
    
    [OSStructureField(Description = "Specifies the Cedar policy language text to be added to or replaced on the static policy.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string Statement;
}