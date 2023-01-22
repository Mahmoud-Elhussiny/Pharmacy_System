using AutoMapper;
using Pharmacy.Application.Business.Crud_representer.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class CreateRepresenterMapper : Profile
    {
        public CreateRepresenterMapper()
        {
            CreateMap<CreateRepresenterEndPointRequest, CreateRepresenterHandlerInput>()
                .ConstructUsing(src => new CreateRepresenterHandlerInput(src.CorrelationId()));
            CreateMap<CreateRepresenterHandlerOutput, CreateRepresenterEndPointResponse>()
               .ConstructUsing(src => new CreateRepresenterEndPointResponse(src.CorrelationId()));
        }

    }
}
