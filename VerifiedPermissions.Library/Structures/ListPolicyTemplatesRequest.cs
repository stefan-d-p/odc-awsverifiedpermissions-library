using System.ComponentModel.DataAnnotations;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Container for the parameters to the ListPolicyTemplates operation.")]
public struct ListPolicyTemplatesRequest
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
    
    [OSStructureField(Description = "Specifies the ID of the policy store that contains the policy templates you want to list.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PolicyStoreId;
}