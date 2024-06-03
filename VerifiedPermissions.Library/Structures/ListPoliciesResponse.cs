using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the ListPolicies operation.")]
public struct ListPoliciesResponse
{
    [OSStructureField(Description = "If present, this value indicates that more output is available than is included in the current response.",
        DataType = OSDataType.Text)]
    public string NextToken;
    
    [OSStructureField(Description = "Lists all policies that are available in the specified policy store.",
        DataType = OSDataType.InferredFromDotNetType)]
    public List<PolicyItem> Policies;
    
    
}