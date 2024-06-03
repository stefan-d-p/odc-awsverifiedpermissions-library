using System.ComponentModel.DataAnnotations;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the UpdatePolicy operation.")]
public struct UpdatePolicyResponse
{
    [OSStructureField(Description = "The action that a policy permits or forbids.",
        DataType = OSDataType.InferredFromDotNetType)]
    public List<ActionIdentifier> Actions;
    
    [OSStructureField(Description = "The date and time that the policy was originally created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;

    [OSStructureField(Description = "The effect of the decision that a policy returns to an authorization request.",
        DataType = OSDataType.Text)]
    public string Effect;
    
    [OSStructureField(Description = "The date and time that the policy was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;
    
    [OSStructureField(Description = "The ID of the policy that was updated.",
        DataType = OSDataType.Text)]
    public string PolicyId;
    
    [OSStructureField(Description = "The ID of the policy store that contains the policy that was updated.",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "The type of the policy that was updated.",
        DataType = OSDataType.Text)]
    public string PolicyType;
    
    [OSStructureField(Description = "The principal specified in the policy's scope.",
        DataType = OSDataType.InferredFromDotNetType)]
    public EntityIdentifier Principal;
    
    [OSStructureField(Description = "The resource specified in the policy's scope.",
        DataType = OSDataType.InferredFromDotNetType)]
    public EntityIdentifier Resource;
}