using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Makes an authorization decision about a service request described in the parameters")]
public struct IsAuthorizedRequest
{
    [OSStructureField(
        Description =
            "Specifies the ID of the policy store. Policies in this policy store will be used to make an authorization decision for the input",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
    
    [OSStructureField(Description = "Specifies the requested action to be authorized. For example, is the principal authorized to perform this action on the resource?",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = false)]
    public ActionIdentifier? Action;
    
    
}