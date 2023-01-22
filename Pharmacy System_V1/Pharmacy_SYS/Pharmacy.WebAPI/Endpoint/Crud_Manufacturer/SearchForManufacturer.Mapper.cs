using AutoMapper;
using Pharmacy.Application.Business.Crud_Manufacturer.Query;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class SearchForManufacturerMapper : Profile
    {
        public SearchForManufacturerMapper()
        {
            CreateMap<SearchForManufacturerEndPointRequest, SearchForManufacturerHandlerInput>()
                .ConstructUsing(src => new SearchForManufacturerHandlerInput(src.CorrelationId()));
            CreateMap<SearchForManufacturerHandlerOutput, SearchForManufacturerEndPointResponse>()
               .ConstructUsing(src => new SearchForManufacturerEndPointResponse(src.CorrelationId()));
        }

    }
}
