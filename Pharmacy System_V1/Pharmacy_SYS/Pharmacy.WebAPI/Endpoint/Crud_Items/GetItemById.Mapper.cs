using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Items.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class GetItemByIdMapper : Profile
    {
        public GetItemByIdMapper()
        {
            CreateMap<GetItemByIdEndPointRequest, GetItemByIdHandlerInput>()
                .ConstructUsing(src => new GetItemByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetItemByIdHandlerOutput, GetItemByIdEndPointResponse>()
               .ConstructUsing(src => new GetItemByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
