using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains information about a filter to refine policies returned in a query")]
public struct PolicyFilter
{
    [OSStructureField(
        Description =
            "Filters the output to only template-linked policies that were instantiated from the specified policy template.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? PolicyTemplateId;
    
    [OSStructureField(Description = "Filters the output to only policies of the specified type.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string? PolicyType;
    
    [OSStructureField(Description = "Filters the output to only policies that reference the specified principal.",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = false)]
    public EntityReference? Principal;
    
    [OSStructureField(Description = "Filters the output to only policies that reference the specified resource.",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = false)]
    public EntityReference? Resource;
}