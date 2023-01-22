using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class GetTheManufacturerByIdHandlerInput : BaseRequest, IRequest<GetTheManufacturerByIdHandlerOutput>
    {
        public GetTheManufacturerByIdHandlerInput() { }
        public GetTheManufacturerByIdHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
