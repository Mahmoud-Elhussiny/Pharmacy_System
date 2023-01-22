using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class CreateTheManufacturerHandlerInput : BaseRequest, IRequest<CreateTheManufacturerHandlerOutput>
    {
        public CreateTheManufacturerHandlerInput() { }
        public CreateTheManufacturerHandlerInput(Guid correlationId) : base(correlationId) { }
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public string Location { get; set; } 
        public string Phone { get; set; }
    }
}
