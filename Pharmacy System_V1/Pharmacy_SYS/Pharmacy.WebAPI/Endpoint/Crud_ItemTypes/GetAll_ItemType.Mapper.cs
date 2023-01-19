using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_ItemTypes.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class GetAll_ItemTypeMapper : Profile
    {
        public GetAll_ItemTypeMapper()
        {
            CreateMap<GetAll_ItemTypeEndPointRequest, GetAll_ItemTypeHandlerInput>()
                .ConstructUsing(src => new GetAll_ItemTypeHandlerInput(src.CorrelationId()));
            CreateMap<GetAll_ItemTypeHandlerOutput, GetAll_ItemTypeEndPointResponse>()
               .ConstructUsing(src => new GetAll_ItemTypeEndPointResponse(src.CorrelationId()));
        }

    }
}
