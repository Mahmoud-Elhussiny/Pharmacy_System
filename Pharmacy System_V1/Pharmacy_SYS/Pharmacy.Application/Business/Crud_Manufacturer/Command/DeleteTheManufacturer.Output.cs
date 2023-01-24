using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class DeleteTheManufacturerHandlerOutput : BaseRessponse
    {
        public DeleteTheManufacturerHandlerOutput() { }
        public DeleteTheManufacturerHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
