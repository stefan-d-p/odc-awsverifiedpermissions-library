using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "This is the response object from the ListPolicyTemplates operation.")]
public struct ListPolicyTemplatesResponse
{
    [OSStructureField(Description = "If present, this value indicates that more output is available than is included in the current response.",
        DataType = OSDataType.Text)]
    public string NextToken;
    
    [OSStructureField(Description = "The list of the policy templates in the specified policy store.",
        DataType = OSDataType.InferredFromDotNetType)]
    public List<PolicyTemplateItem> PolicyTemplates;
}