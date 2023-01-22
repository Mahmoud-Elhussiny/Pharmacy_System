using AutoMapper;
using Pharmacy.Application.Business.Crud_DisCompany.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class GetAllDistributedCompanyMapper : Profile
    {
        public GetAllDistributedCompanyMapper()
        {
            CreateMap<GetAllDistributedCompanyEndPointRequest, GetAllDistributedCompanyHandlerInput>()
                .ConstructUsing(src => new GetAllDistributedCompanyHandlerInput(src.CorrelationId()));
            CreateMap<GetAllDistributedCompanyHandlerOutput, GetAllDistributedCompanyEndPointResponse>()
               .ConstructUsing(src => new GetAllDistributedCompanyEndPointResponse(src.CorrelationId()));
        }

    }
}
