using System.Runtime.Serialization;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = " structure that contains details about a static policy")]
public struct StaticPolicyDefinitionDetail
{
    [OSStructureField(Description = "A description of the static policy",
        DataType = OSDataType.Text)]
    public string Description;

    [OSStructureField(Description = "The content of the static policy written in the Cedar policy language",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string Statement;
}