using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the ListPolicies operation.")]
public struct ListPoliciesRequest
{
    [OSStructureField(
        Description = "Specifies a filter that limits the response to only policies that match the specifiedcriteria.",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = false)]
    public PolicyFilter? Filter;
    
    [OSStructureField(Description = "Specifies the total number of results that you want included in each response.",
        DataType = OSDataType.Integer,
        IsMandatory = false,
        DefaultValue = "10")]
    public int MaxResults;
    
    [OSStructureField(Description = "Specifies that you want to receive the next page of results.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? NextToken;
    
    [OSStructureField(Description = "Specifies the ID of the policy store you want to list policies from.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}