using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Units.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Search_UnitMapper : Profile
    {
        public Search_UnitMapper()
        {
            CreateMap<Search_UnitEndPointRequest, Search_UnitHandlerInput>()
                .ConstructUsing(src => new Search_UnitHandlerInput(src.CorrelationId()));
            CreateMap<Search_UnitHandlerOutput, Search_UnitEndPointResponse>()
               .ConstructUsing(src => new Search_UnitEndPointResponse(src.CorrelationId()));
        }

    }
}
