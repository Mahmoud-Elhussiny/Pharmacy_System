using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class UpdateTheManufacturerHandlerOutput : BaseRessponse
    {
        public UpdateTheManufacturerHandlerOutput() { }
        public UpdateTheManufacturerHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
