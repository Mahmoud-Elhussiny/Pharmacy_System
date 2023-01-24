using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class UpdateDistributedCompanyHandlerOutput : BaseRessponse
    {
        public UpdateDistributedCompanyHandlerOutput() { }
        public UpdateDistributedCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
