using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_DisCompany.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class SearchForDistributedCompanyMapper : Profile
    {
        public SearchForDistributedCompanyMapper()
        {
            CreateMap<SearchForDistributedCompanyEndPointRequest, SearchForDistributedCompanyHandlerInput>()
                .ConstructUsing(src => new SearchForDistributedCompanyHandlerInput(src.CorrelationId()));
            CreateMap<SearchForDistributedCompanyHandlerOutput, SearchForDistributedCompanyEndPointResponse>()
               .ConstructUsing(src => new SearchForDistributedCompanyEndPointResponse(src.CorrelationId()));
        }

    }
}
