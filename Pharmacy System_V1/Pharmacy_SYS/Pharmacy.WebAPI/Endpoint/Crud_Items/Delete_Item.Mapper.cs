using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Items.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Delete_ItemMapper : Profile
    {
        public Delete_ItemMapper()
        {
            CreateMap<Delete_ItemEndPointRequest, Delete_ItemHandlerInput>()
                .ConstructUsing(src => new Delete_ItemHandlerInput(src.CorrelationId()));
            CreateMap<Delete_ItemHandlerOutput, Delete_ItemEndPointResponse>()
               .ConstructUsing(src => new Delete_ItemEndPointResponse(src.CorrelationId()));
        }

    }
}
