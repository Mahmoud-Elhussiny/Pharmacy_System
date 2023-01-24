using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Calenders.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Update_CalenderMapper : Profile
    {
        public Update_CalenderMapper()
        {
            CreateMap<Update_CalenderEndPointRequest, Update_CalenderHandlerInput>()
                .ConstructUsing(src => new Update_CalenderHandlerInput(src.CorrelationId()));
            CreateMap<Update_CalenderHandlerOutput, Update_CalenderEndPointResponse>()
               .ConstructUsing(src => new Update_CalenderEndPointResponse(src.CorrelationId()));
        }

    }
}
