using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Calenders.Quary;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Search_CalenderMapper : Profile
    {
        public Search_CalenderMapper()
        {
            CreateMap<Search_CalenderEndPointRequest, Search_CalenderHandlerInput>()
                .ConstructUsing(src => new Search_CalenderHandlerInput(src.CorrelationId()));
            CreateMap<Search_CalenderHandlerOutput, Search_CalenderEndPointResponse>()
               .ConstructUsing(src => new Search_CalenderEndPointResponse(src.CorrelationId()));
        }

    }
}
