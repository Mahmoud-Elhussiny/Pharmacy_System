using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Calenders.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Create_CalenderMapper : Profile
    {
        public Create_CalenderMapper()
        {
            CreateMap<Create_CalenderEndPointRequest, Create_CalenderHandlerInput>()
                .ConstructUsing(src => new Create_CalenderHandlerInput(src.CorrelationId()));
            CreateMap<Create_CalenderHandlerOutput, Create_CalenderEndPointResponse>()
               .ConstructUsing(src => new Create_CalenderEndPointResponse(src.CorrelationId()));
        }

    }
}
