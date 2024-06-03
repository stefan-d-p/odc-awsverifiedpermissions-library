using System.ComponentModel.DataAnnotations;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.VerifiedPermissions.Structures;

[OSStructure(Description = "Creates a policy store. A policy store is a container for policy resources.")]
public struct CreatePolicyStoreRequest
{
    [OSStructureField(
        Description =
            "Specifies a unique, case-sensitive ID that you provide to ensure the idempotency of the request.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string ClientToken;
    
    [OSStructureField(Description = "Descriptive text that you can provide to help with identification of the current policy store.",
        DataType = OSDataType.Text,
        IsMandatory = false)]
    public string Description;

    [OSStructureField(
        Description =
            "Specifies the validation setting for this policy store. Valued values for Mode OFF and STRICT. Recommended STRICT",
        DataType = OSDataType.InferredFromDotNetType,
        IsMandatory = true)]
    public ValidationSettings ValidationSettings;

}