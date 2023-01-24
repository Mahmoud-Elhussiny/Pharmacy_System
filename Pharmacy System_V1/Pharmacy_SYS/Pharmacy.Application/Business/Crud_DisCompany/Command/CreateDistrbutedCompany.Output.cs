using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class CreateDistrbutedCompanyHandlerOutput : BaseRessponse
    {
        public CreateDistrbutedCompanyHandlerOutput() { }
        public CreateDistrbutedCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
