using AutoMapper;
using Pharmacy.Application.Business.Crud_representer.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class DeleteRepresenterMapper : Profile
    {
        public DeleteRepresenterMapper()
        {
            CreateMap<DeleteRepresenterEndPointRequest, DeleteRepresenterHandlerInput>()
                .ConstructUsing(src => new DeleteRepresenterHandlerInput(src.CorrelationId()));
            CreateMap<DeleteRepresenterHandlerOutput, DeleteRepresenterEndPointResponse>()
               .ConstructUsing(src => new DeleteRepresenterEndPointResponse(src.CorrelationId()));
        }

    }
}
