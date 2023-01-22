using AutoMapper;
using Pharmacy.Application.Business.Crud_Manufacturer.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class UpdateTheManufacturerMapper : Profile
    {
        public UpdateTheManufacturerMapper()
        {
            CreateMap<UpdateTheManufacturerEndPointRequest, UpdateTheManufacturerHandlerInput>()
                .ConstructUsing(src => new UpdateTheManufacturerHandlerInput(src.CorrelationId()));
            CreateMap<UpdateTheManufacturerHandlerOutput, UpdateTheManufacturerEndPointResponse>()
               .ConstructUsing(src => new UpdateTheManufacturerEndPointResponse(src.CorrelationId()));
        }

    }
}
