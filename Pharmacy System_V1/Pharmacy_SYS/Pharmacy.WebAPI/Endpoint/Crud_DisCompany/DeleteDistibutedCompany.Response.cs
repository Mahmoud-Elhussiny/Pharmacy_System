

using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class DeleteDistibutedCompanyEndPointResponse : BaseResponse
    {
        public DeleteDistibutedCompanyEndPointResponse() { }
        public DeleteDistibutedCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
