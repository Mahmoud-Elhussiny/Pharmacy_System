using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Command
{
    public class UpdateRepresnterHandlerOutput : BaseRessponse
    {
        public UpdateRepresnterHandlerOutput() { }
        public UpdateRepresnterHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }


    }
}
