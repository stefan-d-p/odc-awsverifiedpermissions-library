using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains information about an action for a request for which an authorization decision is made")]
public struct ActionIdentifier
{
    [OSStructureField(Description = "The ID of an action",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string ActionId;
    
    [OSStructureField(Description = "The type of an action",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string ActionType;
}