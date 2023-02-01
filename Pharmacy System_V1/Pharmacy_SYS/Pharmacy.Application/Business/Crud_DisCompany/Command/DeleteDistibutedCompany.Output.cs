using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class DeleteDistibutedCompanyHandlerOutput : BaseResponse
    {
        public DeleteDistibutedCompanyHandlerOutput() { }
        public DeleteDistibutedCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
