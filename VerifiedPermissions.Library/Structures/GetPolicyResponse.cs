using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "GetPolicy Response")]
public struct GetPolicyResponse
{
    [OSStructureField(Description = "The action that a policy permits or forbids")]
    public List<ActionIdentifier> Actions;

    [OSStructureField(Description = "The date and time that the policy was originally created")]
    public DateTime CreatedDate;

    [OSStructureField(Description = "The definition of the requested policy")]
    public PolicyDefinition Definition;

    [OSStructureField(Description = "The effect of the decision that a policy returns to an authorization request")]
    public string Effect;
    
    [OSStructureField(Description = "The date and time that the policy was last updated",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;
    
    [OSStructureField(Description = "The unique ID of the policy that you want information about",
        DataType = OSDataType.Text)]
    public string PolicyId;
    
    [OSStructureField(Description = "The ID of the policy store that contains the policy that you want information about",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The type of the policy",
        DataType = OSDataType.Text)]
    public string PolicyType;

    [OSStructureField(Description = "The principal specified in the policy's scope")]
    public EntityIdentifier Principal;
    
    [OSStructureField(Description = "The resource specified in the policy's scope")]
    public EntityIdentifier Resource;
    
}