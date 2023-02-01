using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class UpdateDistributedCompanyEndPointResponse : BaseResponse
    {
        public UpdateDistributedCompanyEndPointResponse() { }
        public UpdateDistributedCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
