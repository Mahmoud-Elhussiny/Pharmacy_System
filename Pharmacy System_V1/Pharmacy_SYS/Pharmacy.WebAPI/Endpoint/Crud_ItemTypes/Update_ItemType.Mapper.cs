using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_ItemTypes.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Update_ItemTypeMapper : Profile
    {
        public Update_ItemTypeMapper()
        {
            CreateMap<Update_ItemTypeEndPointRequest, Update_ItemTypeHandlerInput>()
                .ConstructUsing(src => new Update_ItemTypeHandlerInput(src.CorrelationId()));
            CreateMap<Update_ItemTypeHandlerOutput, Update_ItemTypeEndPointResponse>()
               .ConstructUsing(src => new Update_ItemTypeEndPointResponse(src.CorrelationId()));
        }

    }
}
