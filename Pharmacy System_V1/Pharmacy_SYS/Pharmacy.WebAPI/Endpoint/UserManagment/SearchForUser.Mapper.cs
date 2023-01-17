using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Query;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class SearchForUserMapper : Profile
    {
        public SearchForUserMapper()
        {
            CreateMap<SearchForUserEndPointRequest, SearchForUserHandlerInput>()
                .ConstructUsing(src => new SearchForUserHandlerInput(src.CorrelationId()));
            CreateMap<SearchForUserHandlerOutput, SearchForUserEndPointResponse>()
               .ConstructUsing(src => new SearchForUserEndPointResponse(src.CorrelationId()));
        }

    }
}
