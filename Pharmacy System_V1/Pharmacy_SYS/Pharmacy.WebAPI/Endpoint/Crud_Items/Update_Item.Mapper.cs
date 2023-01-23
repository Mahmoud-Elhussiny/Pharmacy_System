using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Items.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Update_ItemMapper : Profile
    {
        public Update_ItemMapper()
        {
            CreateMap<Update_ItemEndPointRequest, Update_ItemHandlerInput>()
                .ConstructUsing(src => new Update_ItemHandlerInput(src.CorrelationId()));
            CreateMap<Update_ItemHandlerOutput, Update_ItemEndPointResponse>()
               .ConstructUsing(src => new Update_ItemEndPointResponse(src.CorrelationId()));
        }

    }
}
