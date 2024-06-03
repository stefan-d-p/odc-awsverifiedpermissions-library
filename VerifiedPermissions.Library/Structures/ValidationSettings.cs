using Amazon.VerifiedPermissions;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "A structure that contains Cedar policy validation settings for the policy store.")]
public struct ValidationSettings
{
    [OSStructureField(Description = "The validation mode currently configured for this policy store.",
        DataType = OSDataType.Text,
        IsMandatory = true,
        DefaultValue = "STRICT")]
    public string Mode;
}