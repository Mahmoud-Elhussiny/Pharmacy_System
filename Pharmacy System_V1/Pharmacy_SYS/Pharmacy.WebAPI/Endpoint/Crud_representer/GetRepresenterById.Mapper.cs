using AutoMapper;
using Pharmacy.Application.Business.Crud_representer.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class GetRepresenterByIdMapper : Profile
    {
        public GetRepresenterByIdMapper()
        {
            CreateMap<GetRepresenterByIdEndPointRequest, GetRepresenterByIdHandlerInput>()
                .ConstructUsing(src => new GetRepresenterByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetRepresenterByIdHandlerOutput, GetRepresenterByIdEndPointResponse>()
               .ConstructUsing(src => new GetRepresenterByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
