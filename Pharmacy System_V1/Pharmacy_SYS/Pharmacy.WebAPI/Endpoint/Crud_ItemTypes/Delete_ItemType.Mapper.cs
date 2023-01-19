using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_ItemTypes.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Delete_ItemTypeMapper : Profile
    {
        public Delete_ItemTypeMapper()
        {
            CreateMap<Delete_ItemTypeEndPointRequest, Delete_ItemTypeHandlerInput>()
                .ConstructUsing(src => new Delete_ItemTypeHandlerInput(src.CorrelationId()));
            CreateMap<Delete_ItemTypeHandlerOutput, Delete_ItemTypeEndPointResponse>()
               .ConstructUsing(src => new Delete_ItemTypeEndPointResponse(src.CorrelationId()));
        }

    }
}
