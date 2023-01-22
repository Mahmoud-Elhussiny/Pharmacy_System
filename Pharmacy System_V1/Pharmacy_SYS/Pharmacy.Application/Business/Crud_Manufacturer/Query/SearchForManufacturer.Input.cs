using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class SearchForManufacturerHandlerInput : BaseRequest, IRequest<SearchForManufacturerHandlerOutput>
    {
        public SearchForManufacturerHandlerInput() { }
        public SearchForManufacturerHandlerInput(Guid correlationId) : base(correlationId) { }
        public int? Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
    }
}
