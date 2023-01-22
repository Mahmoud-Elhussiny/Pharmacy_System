using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class CreateDistrbutedCompanyHandlerOutput : BaseResponse
    {
        public CreateDistrbutedCompanyHandlerOutput() { }
        public CreateDistrbutedCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
