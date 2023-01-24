using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Calenders.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Delete_CalenderMapper : Profile
    {
        public Delete_CalenderMapper()
        {
            CreateMap<Delete_CalenderEndPointRequest, Delete_CalenderHandlerInput>()
                .ConstructUsing(src => new Delete_CalenderHandlerInput(src.CorrelationId()));
            CreateMap<Delete_CalenderHandlerOutput, Delete_CalenderEndPointResponse>()
               .ConstructUsing(src => new Delete_CalenderEndPointResponse(src.CorrelationId()));
        }

    }
}
