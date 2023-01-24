using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Items.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Search_ItemMapper : Profile
    {
        public Search_ItemMapper()
        {
            CreateMap<Search_ItemEndPointRequest, Search_ItemHandlerInput>()
                .ConstructUsing(src => new Search_ItemHandlerInput(src.CorrelationId()));
            CreateMap<Search_ItemHandlerOutput, Search_ItemEndPointResponse>()
               .ConstructUsing(src => new Search_ItemEndPointResponse(src.CorrelationId()));
        }

    }
}
