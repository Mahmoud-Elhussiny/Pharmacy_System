using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Command
{
    public class CreateRepresenterHandlerOutput : BaseRessponse
    {
        public CreateRepresenterHandlerOutput() { }
        public CreateRepresenterHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
