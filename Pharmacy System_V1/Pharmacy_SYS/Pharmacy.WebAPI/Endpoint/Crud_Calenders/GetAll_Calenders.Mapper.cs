using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Calenders.Quary;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class GetAll_CalendersMapper : Profile
    {
        public GetAll_CalendersMapper()
        {
            CreateMap<GetAll_CalendersEndPointRequest, GetAll_CalendersHandlerInput>()
                .ConstructUsing(src => new GetAll_CalendersHandlerInput(src.CorrelationId()));
            CreateMap<GetAll_CalendersHandlerOutput, GetAll_CalendersEndPointResponse>()
               .ConstructUsing(src => new GetAll_CalendersEndPointResponse(src.CorrelationId()));
        }

    }
}
