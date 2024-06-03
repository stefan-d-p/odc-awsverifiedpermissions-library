using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the ListPolicyStores operation.")]
public struct ListPolicyStoresRequest
{
    [OSStructureField(Description = "Specifies the total number of results that you want included in each response.",
        DataType = OSDataType.Integer,
        IsMandatory = false,
        DefaultValue = "10")]
    public int MaxResults;
    
    [OSStructureField(Description = "Specifies that you want to receive the next page of results.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? NextToken;
}