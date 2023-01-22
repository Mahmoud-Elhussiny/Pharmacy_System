using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Units.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Create_UnitsMapper : Profile
    {
        public Create_UnitsMapper()
        {
            CreateMap<Create_UnitsEndPointRequest, Create_UnitsHandlerInput>()
                .ConstructUsing(src => new Create_UnitsHandlerInput(src.CorrelationId()));
            CreateMap<Create_UnitsHandlerOutput, Create_UnitsEndPointResponse>()
               .ConstructUsing(src => new Create_UnitsEndPointResponse(src.CorrelationId()));
        }

    }
}
