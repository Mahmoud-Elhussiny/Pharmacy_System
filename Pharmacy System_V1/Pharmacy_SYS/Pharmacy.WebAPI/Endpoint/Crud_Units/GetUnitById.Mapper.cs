using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Units.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class GetUnitByIdMapper : Profile
    {
        public GetUnitByIdMapper()
        {
            CreateMap<GetUnitByIdEndPointRequest, GetUnitByIdHandlerInput>()
                .ConstructUsing(src => new GetUnitByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetUnitByIdHandlerOutput, GetUnitByIdEndPointResponse>()
               .ConstructUsing(src => new GetUnitByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
