using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class CreateTheManufacturerHandlerOutput : BaseRessponse
    {
        public CreateTheManufacturerHandlerOutput() { }
        public CreateTheManufacturerHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }


    }
}
