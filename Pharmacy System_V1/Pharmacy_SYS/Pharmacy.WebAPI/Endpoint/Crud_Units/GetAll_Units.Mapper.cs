using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Units.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class GetAll_UnitsMapper : Profile
    {
        public GetAll_UnitsMapper()
        {
            CreateMap<GetAll_UnitsEndPointRequest, GetAll_UnitsHandlerInput>()
                .ConstructUsing(src => new GetAll_UnitsHandlerInput(src.CorrelationId()));
            CreateMap<GetAll_UnitsHandlerOutput, GetAll_UnitsEndPointResponse>()
               .ConstructUsing(src => new GetAll_UnitsEndPointResponse(src.CorrelationId()));
        }

    }
}
