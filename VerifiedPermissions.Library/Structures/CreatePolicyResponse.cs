using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the CreatePolicy operation")]
public struct CreatePolicyResponse
{
    [OSStructureField(Description = "The action that a policy permits or forbids")]
    public List<ActionIdentifier> Actions;

    [OSStructureField(Description = "The date and time the policy was originally created",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "The effect of the decision that a policy returns to an authorization request.",
        DataType = OSDataType.Text)]
    public string Effect;
    
    [OSStructureField(Description = "The date and time the policy was last updated.",
        DataType = OSDataType.Text)]
    public DateTime LastUpdatedDate;
    
    [OSStructureField(Description = "The unique ID of the new policy",
        DataType = OSDataType.Text)]
    public string PolicyId;
    
    [OSStructureField(Description = "The ID of the policy store that contains the new policy.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The policy type of the new policy.",
        DataType = OSDataType.Text)]
    public string PolicyType;
    
    [OSStructureField(Description = "The principal specified in the new policy's scope.",
        DataType = OSDataType.InferredFromDotNetType)]
    public EntityIdentifier Principal;
    
    [OSStructureField(Description = "The resource specified in the new policy's scope.",
        DataType = OSDataType.InferredFromDotNetType)]
    public EntityIdentifier Resource;
    
}