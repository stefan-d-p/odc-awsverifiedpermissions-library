using System.Net;
using Amazon;
using Amazon.Runtime;
using Amazon.VerifiedPermissions;
using AutoMapper;
using Without.Systems.VerifiedPermissions.Extensions;

namespace Without.Systems.VerifiedPermissions;

public class VerifiedPermissions : IVerifiedPermissions
{
    private readonly IMapper _mapper;
    
    public VerifiedPermissions()
    {
        MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
        {
            /*
             * Request Mappings
             */
            cfg.CreateMap<Structures.GetPolicyRequest,
                Amazon.VerifiedPermissions.Model.GetPolicyRequest>();
            cfg.CreateMap<Structures.CreatePolicyRequest,
                Amazon.VerifiedPermissions.Model.CreatePolicyRequest>();
            cfg.CreateMap<Structures.CreatePolicyStoreRequest,
                Amazon.VerifiedPermissions.Model.CreatePolicyStoreRequest>();
            cfg.CreateMap<Structures.CreatePolicyTemplateRequest,
                Amazon.VerifiedPermissions.Model.CreatePolicyTemplateRequest>();
            cfg.CreateMap<Structures.DeletePolicyRequest,
                Amazon.VerifiedPermissions.Model.DeletePolicyRequest>();
            cfg.CreateMap<Structures.DeletePolicyStoreRequest,
                Amazon.VerifiedPermissions.Model.DeletePolicyStoreRequest>();
            cfg.CreateMap<Structures.DeletePolicyTemplateRequest,
                Amazon.VerifiedPermissions.Model.DeletePolicyTemplateRequest>();
            cfg.CreateMap<Structures.GetPolicyStoreRequest,
                Amazon.VerifiedPermissions.Model.GetPolicyStoreRequest>();
            cfg.CreateMap<Structures.GetPolicyTemplateRequest,
                Amazon.VerifiedPermissions.Model.GetPolicyTemplateRequest>();
            cfg.CreateMap<Structures.GetSchemaRequest,
                Amazon.VerifiedPermissions.Model.GetSchemaRequest>();
            cfg.CreateMap<Structures.ListPoliciesRequest,
                Amazon.VerifiedPermissions.Model.ListPoliciesRequest>();
            cfg.CreateMap<Structures.ListPolicyStoresRequest,
                Amazon.VerifiedPermissions.Model.ListPolicyStoresRequest>();
            cfg.CreateMap<Structures.PutSchemaRequest,
                Amazon.VerifiedPermissions.Model.PutSchemaRequest>();
            cfg.CreateMap<Structures.ListPolicyTemplatesRequest,
                Amazon.VerifiedPermissions.Model.ListPolicyTemplatesRequest>();
            cfg.CreateMap<Structures.UpdatePolicyRequest,
                Amazon.VerifiedPermissions.Model.UpdatePolicyRequest>();
            
            /*
             * Response Mappings
             */
            
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.GetPolicyResponse,
                Structures.GetPolicyResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.CreatePolicyResponse,
                Structures.CreatePolicyResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.CreatePolicyStoreResponse,
                Structures.CreatePolicyStoreResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.CreatePolicyTemplateResponse,
                Structures.CreatePolicyTemplateResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.GetPolicyStoreResponse,
                Structures.GetPolicyStoreResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.GetPolicyTemplateResponse,
                Structures.GetPolicyTemplateResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.GetSchemaResponse,
                Structures.GetSchemaResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.ListPoliciesResponse,
                Structures.ListPoliciesResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.ListPolicyStoresResponse,
                Structures.ListPolicyStoresResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.PutSchemaResponse,
                Structures.PutSchemaResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.ListPolicyTemplatesResponse,
                Structures.ListPolicyTemplatesResponse>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.UpdatePolicyResponse,
                Structures.UpdatePolicyResponse>();
            
            /*
             * Individual Mappings
             */

            
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.EntityIdentifier,
                Structures.EntityIdentifier>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.PolicyDefinition,
                Structures.PolicyDefinition>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.StaticPolicyDefinitionDetail,
                Structures.StaticPolicyDefinitionDetail>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.TemplateLinkedPolicyDefinitionDetail,
                Structures.TemplateLinkedPolicyDefinitionDetail>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.StaticPolicyDefinitionItem,
                Structures.StaticPolicyDefinitionItem>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.TemplateLinkedPolicyDefinitionItem,
                Structures.TemplateLinkedPolicyDefinitionItem>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.PolicyDefinitionItem,
                Structures.PolicyDefinitionItem>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.PolicyItem,
                Structures.PolicyItem>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.PolicyStoreItem,
                Structures.PolicyStoreItem>();
            cfg.CreateMap<Amazon.VerifiedPermissions.Model.PolicyTemplateItem,
                Structures.PolicyTemplateItem>();

            cfg.CreateMap<Structures.UpdateStaticPolicyDefinition,
                Amazon.VerifiedPermissions.Model.UpdateStaticPolicyDefinition>();
            cfg.CreateMap<Structures.UpdatePolicyDefinition,
                Amazon.VerifiedPermissions.Model.UpdatePolicyDefinition>();
            cfg.CreateMap<Structures.SchemaDefinition,
                Amazon.VerifiedPermissions.Model.SchemaDefinition>();
            cfg.CreateMap<Structures.EntityReference,
                Amazon.VerifiedPermissions.Model.EntityReference>();
            cfg.CreateMap<Structures.ValidationSettings,
                    Amazon.VerifiedPermissions.Model.ValidationSettings>()
                .ForMember(dest => dest.Mode,
                    opt => opt.MapFrom(src => Amazon.VerifiedPermissions.ValidationMode.FindValue(src.Mode)));
            cfg.CreateMap<Structures.PolicyFilter,
                    Amazon.VerifiedPermissions.Model.PolicyFilter>()
                .ForMember(dest => dest.PolicyType, opt => opt.MapFrom(src => PolicyType.FindValue(src.PolicyType)));
            
        });
        
        _mapper = mapperConfiguration.CreateMapper();
        
    }
    
    public string Echo(string message)
    {
        return message;
    }
    
    private AmazonVerifiedPermissionsClient GetAwsVerifiedPermissionsClient(Structures.Credentials credentials, string region) =>
        new AmazonVerifiedPermissionsClient(credentials.ToAwsCredentials(), RegionEndpoint.GetBySystemName(region));

    private void ParseResponse(AmazonWebServiceResponse response)
    {
        if (!(response.HttpStatusCode.Equals(HttpStatusCode.OK) || response.HttpStatusCode.Equals(HttpStatusCode.NoContent)))
            throw new Exception($"Error in operation ({response.HttpStatusCode})");
    }
}