using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Items.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class GetAll_ItemsMapper : Profile
    {
        public GetAll_ItemsMapper()
        {
            CreateMap<GetAll_ItemsEndPointRequest, GetAll_ItemsHandlerInput>()
                .ConstructUsing(src => new GetAll_ItemsHandlerInput(src.CorrelationId()));
            CreateMap<GetAll_ItemsHandlerOutput, GetAll_ItemsEndPointResponse>()
               .ConstructUsing(src => new GetAll_ItemsEndPointResponse(src.CorrelationId()));
        }

    }
}
