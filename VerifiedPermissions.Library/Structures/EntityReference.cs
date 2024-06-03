using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = " Contains information about a principal or resource that can be referenced in a Cedar policy.")]
public struct EntityReference
{
    [OSStructureField(Description = "The identifier of the entity.",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = false)]
    public EntityIdentifier? Identifier;
    
    
    [OSStructureField(Description = "Used to indicate that a principal or resource is not specified",
        DataType = OSDataType.Boolean,
        IsMandatory = false,
        DefaultValue = "false")]
    public bool Unspecified;
    
}