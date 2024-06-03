using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "The value of an attribute")]
public struct AttributeValue
{
    [OSStructureField(Description = "A boolean attribute value",
        DataType = OSDataType.Boolean,
        IsMandatory = false)]
    public bool? Boolean;
    
    [OSStructureField(Description = "A EntityIdentifier value",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = false)]
    public EntityIdentifier? EntityIdentifier;
    
    [OSStructureField(Description = "A long attribute value",
        DataType = OSDataType.LongInteger,
        IsMandatory = false)]
    public long? Long;
        
    
    [OSStructureField(Description = "A string attribute value",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? String;
}