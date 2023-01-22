using AutoMapper;
using Pharmacy.Application.Business.Crud_Manufacturer.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class GetAllManufacturersMapper : Profile
    {
        public GetAllManufacturersMapper()
        {
            CreateMap<GetAllManufacturersEndPointRequest, GetAllManufacturersHandlerInput>()
                .ConstructUsing(src => new GetAllManufacturersHandlerInput(src.CorrelationId()));
            CreateMap<GetAllManufacturersHandlerOutput, GetAllManufacturersEndPointResponse>()
               .ConstructUsing(src => new GetAllManufacturersEndPointResponse(src.CorrelationId()));
        }

    }
}
