using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_ItemTypes.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Create_ItemTypeMapper : Profile
    {
        public Create_ItemTypeMapper()
        {
            CreateMap<Create_ItemTypeEndPointRequest, Create_ItemTypeHandlerInput>()
                .ConstructUsing(src => new Create_ItemTypeHandlerInput(src.CorrelationId()));
            CreateMap<Create_ItemTypeHandlerOutput, Create_ItemTypeEndPointResponse>()
               .ConstructUsing(src => new Create_ItemTypeEndPointResponse(src.CorrelationId()));
        }

    }
}
