using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_representer.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class UpdateRepresnterMapper : Profile
    {
        public UpdateRepresnterMapper()
        {
            CreateMap<UpdateRepresnterEndPointRequest, UpdateRepresnterHandlerInput>()
                .ConstructUsing(src => new UpdateRepresnterHandlerInput(src.CorrelationId()));
            CreateMap<UpdateRepresnterHandlerOutput, UpdateRepresnterEndPointResponse>()
               .ConstructUsing(src => new UpdateRepresnterEndPointResponse(src.CorrelationId()));
        }

    }
}
