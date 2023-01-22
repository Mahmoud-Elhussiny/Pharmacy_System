using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_representer.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class GetAllRepresentersMapper : Profile
    {
        public GetAllRepresentersMapper()
        {
            CreateMap<GetAllRepresentersEndPointRequest, GetAllRepresentersHandlerInput>()
                .ConstructUsing(src => new GetAllRepresentersHandlerInput(src.CorrelationId()));
            CreateMap<GetAllRepresentersHandlerOutput, GetAllRepresentersEndPointResponse>()
               .ConstructUsing(src => new GetAllRepresentersEndPointResponse(src.CorrelationId()));
        }

    }
}
