using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class UpdateDistributedCompanyHandlerOutput : BaseResponse
    {
        public UpdateDistributedCompanyHandlerOutput() { }
        public UpdateDistributedCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
