using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Calenders.Quary;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class GetCalenderByIdMapper : Profile
    {
        public GetCalenderByIdMapper()
        {
            CreateMap<GetCalenderByIdEndPointRequest, GetCalenderByIdHandlerInput>()
                .ConstructUsing(src => new GetCalenderByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetCalenderByIdHandlerOutput, GetCalenderByIdEndPointResponse>()
               .ConstructUsing(src => new GetCalenderByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
