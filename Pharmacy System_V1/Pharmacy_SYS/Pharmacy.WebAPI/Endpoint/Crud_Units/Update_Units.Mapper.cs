using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Units.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Update_UnitsMapper : Profile
    {
        public Update_UnitsMapper()
        {
            CreateMap<Update_UnitsEndPointRequest, Update_UnitsHandlerInput>()
                .ConstructUsing(src => new Update_UnitsHandlerInput(src.CorrelationId()));
            CreateMap<Update_UnitsHandlerOutput, Update_UnitsEndPointResponse>()
               .ConstructUsing(src => new Update_UnitsEndPointResponse(src.CorrelationId()));
        }

    }
}
