using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Items.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Create_ItemMapper : Profile
    {
        public Create_ItemMapper()
        {
            CreateMap<Create_ItemEndPointRequest, Create_ItemHandlerInput>()
                .ConstructUsing(src => new Create_ItemHandlerInput(src.CorrelationId()));
            CreateMap<Create_ItemHandlerOutput, Create_ItemEndPointResponse>()
               .ConstructUsing(src => new Create_ItemEndPointResponse(src.CorrelationId()));
        }

    }
}
