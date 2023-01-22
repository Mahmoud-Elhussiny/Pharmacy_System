using AutoMapper;
using Pharmacy.Application.Business.Crud_Manufacturer.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class CreateTheManufacturerMapper : Profile
    {
        public CreateTheManufacturerMapper()
        {
            CreateMap<CreateTheManufacturerEndPointRequest, CreateTheManufacturerHandlerInput>()
                .ConstructUsing(src => new CreateTheManufacturerHandlerInput(src.CorrelationId()));
            CreateMap<CreateTheManufacturerHandlerOutput, CreateTheManufacturerEndPointResponse>()
               .ConstructUsing(src => new CreateTheManufacturerEndPointResponse(src.CorrelationId()));
        }

    }
}
