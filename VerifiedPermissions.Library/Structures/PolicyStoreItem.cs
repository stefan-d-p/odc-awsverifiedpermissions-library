using System.ComponentModel.DataAnnotations;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Contains information about a policy store.")]
public struct PolicyStoreItem
{
    [OSStructureField(Description = "The Amazon Resource Name (ARN) of the policy store.",
        DataType = OSDataType.Text)]
    public string Arn;

    [OSStructureField(Description = "The date and time the policy was created.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDate;
    
    [OSStructureField(Description = "Descriptive text that you can provide to help with identification of the current policy store.",
        DataType = OSDataType.Text)]
    public string Description;
    
    [OSStructureField(Description = "The date and time the policy store was most recently updated.",
        DataType = OSDataType.DateTime)]
    public DateTime LastUpdatedDate;

    [OSStructureField(Description = "The unique identifier of the policy store",
        DataType = OSDataType.Text)]
    public string PolicyStoreId;
}