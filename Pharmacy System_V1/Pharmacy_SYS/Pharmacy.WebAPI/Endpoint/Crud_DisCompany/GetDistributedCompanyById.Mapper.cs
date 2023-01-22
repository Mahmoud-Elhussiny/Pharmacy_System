using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_DisCompany.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class GetDistributedCompanyByIdMapper : Profile
    {
        public GetDistributedCompanyByIdMapper()
        {
            CreateMap<GetDistributedCompanyByIdEndPointRequest, GetDistributedCompanyByIdHandlerInput>()
                .ConstructUsing(src => new GetDistributedCompanyByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetDistributedCompanyByIdHandlerOutput, GetDistributedCompanyByIdEndPointResponse>()
               .ConstructUsing(src => new GetDistributedCompanyByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
