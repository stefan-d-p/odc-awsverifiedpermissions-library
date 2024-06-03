using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains the identifier of an entity, including its ID and type")]
public struct EntityIdentifier
{
    [OSStructureField(Description = "The identifier of an entity",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string EntityId;
    
    [OSStructureField(Description = "The type of an entity",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string EntityType;
}