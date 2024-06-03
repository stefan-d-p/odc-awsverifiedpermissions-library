using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "A structure that contains details about a static policy. It includes the description and policy statement.")]
public struct StaticPolicyDefinitionItem
{
    [OSStructureField(Description = "A description of the static policy.",
        DataType = OSDataType.Text)]
    public string Description;
}