using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class DeleteTheManufacturerHandlerInput : BaseRequest, IRequest<DeleteTheManufacturerHandlerOutput>
    {
        public DeleteTheManufacturerHandlerInput() { }
        public DeleteTheManufacturerHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
