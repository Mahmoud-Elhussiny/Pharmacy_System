using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_ItemTypes.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Search_ItemTypeMapper : Profile
    {
        public Search_ItemTypeMapper()
        {
            CreateMap<Search_ItemTypeEndPointRequest, Search_ItemTypeHandlerInput>()
                .ConstructUsing(src => new Search_ItemTypeHandlerInput(src.CorrelationId()));
            CreateMap<Search_ItemTypeHandlerOutput, Search_ItemTypeEndPointResponse>()
               .ConstructUsing(src => new Search_ItemTypeEndPointResponse(src.CorrelationId()));
        }

    }
}
