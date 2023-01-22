using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Units.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Delete_UnitsMapper : Profile
    {
        public Delete_UnitsMapper()
        {
            CreateMap<Delete_UnitsEndPointRequest, Delete_UnitsHandlerInput>()
                .ConstructUsing(src => new Delete_UnitsHandlerInput(src.CorrelationId()));
            CreateMap<Delete_UnitsHandlerOutput, Delete_UnitsEndPointResponse>()
               .ConstructUsing(src => new Delete_UnitsEndPointResponse(src.CorrelationId()));
        }

    }
}
