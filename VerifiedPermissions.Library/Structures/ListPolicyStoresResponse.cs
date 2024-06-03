using System.ComponentModel.DataAnnotations;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the ListPolicyStores operation.")]
public struct ListPolicyStoresResponse
{
    [OSStructureField(Description = "If present, this value indicates that more output is available than is included in the current response",
        DataType=OSDataType.Text)]
    public string NextToken;
    
    [OSStructureField(Description = "The list of policy stores in the account.",
        DataType = OSDataType.InferredFromDotNetType)]
    public List<PolicyStoreItem> PolicyStores;
    
}