using AutoMapper;
using Pharmacy.Application.Business.Crud_Manufacturer.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class DeleteTheManufacturerMapper : Profile
    {
        public DeleteTheManufacturerMapper()
        {
            CreateMap<DeleteTheManufacturerEndPointRequest, DeleteTheManufacturerHandlerInput>()
                .ConstructUsing(src => new DeleteTheManufacturerHandlerInput(src.CorrelationId()));
            CreateMap<DeleteTheManufacturerHandlerOutput, DeleteTheManufacturerEndPointResponse>()
               .ConstructUsing(src => new DeleteTheManufacturerEndPointResponse(src.CorrelationId()));
        }

    }
}
