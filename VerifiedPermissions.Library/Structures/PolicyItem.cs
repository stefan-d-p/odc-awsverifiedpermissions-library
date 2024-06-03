using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains information about a policy.")]
public struct PolicyItem
{
    [OSStructureField(Description = "The action that a policy permits or forbids.",
        DataType = OSDataType.InferredFromDotNetType)]
    public List<ActionIdentifier> Actions;
    
    [OSStructureField(Description = "The date and time the policy was created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;

    [OSStructureField(Description = "The policy definition of an item in the list of policies returned.",
        DataType = OSDataType.InferredFromDotNetType)]
    public PolicyDefinitionItem Definition;
    
    [OSStructureField(Description = "The effect of the decision that a policy returns to an authorization request.",
        DataType = OSDataType.Text)]
    public string Effect;
    
    [OSStructureField(Description = "The date and time the policy was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;
    
    [OSStructureField(Description = "The identifier of the policy you want information about.",
        DataType = OSDataType.Text)]
    public string PolicyId;
    
    [OSStructureField(Description = "The identifier of the PolicyStore where the policy you want information about is stored.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The type of the policy.",
        DataType = OSDataType.Text)]
    public string PolicyType;

    [OSStructureField(Description = "The principal associated with the policy.",
        DataType = OSDataType.InferredFromDotNetType)]
    public EntityIdentifier Principal;
    
    [OSStructureField(Description = "The resource associated with the policy.",
        DataType = OSDataType.InferredFromDotNetType)]
    public EntityIdentifier Resource;
}