using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_ItemTypes.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class GetItemTypeByIdMapper : Profile
    {
        public GetItemTypeByIdMapper()
        {
            CreateMap<GetItemTypeByIdEndPointRequest, GetItemTypeByIdHandlerInput>()
                .ConstructUsing(src => new GetItemTypeByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetItemTypeByIdHandlerOutput, GetItemTypeByIdEndPointResponse>()
               .ConstructUsing(src => new GetItemTypeByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
