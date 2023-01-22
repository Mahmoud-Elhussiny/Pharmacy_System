using AutoMapper;
using Pharmacy.Application.Business.Crud_Manufacturer.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class GetTheManufacturerByIdMapper : Profile
    {
        public GetTheManufacturerByIdMapper()
        {
            CreateMap<GetTheManufacturerByIdEndPointRequest, GetTheManufacturerByIdHandlerInput>()
                .ConstructUsing(src => new GetTheManufacturerByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetTheManufacturerByIdHandlerOutput, GetTheManufacturerByIdEndPointResponse>()
               .ConstructUsing(src => new GetTheManufacturerByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
