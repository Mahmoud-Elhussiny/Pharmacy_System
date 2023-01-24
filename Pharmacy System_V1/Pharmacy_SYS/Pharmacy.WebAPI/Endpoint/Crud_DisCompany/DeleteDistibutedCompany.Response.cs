

using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class DeleteDistibutedCompanyEndPointResponse : BaseRessponse
    {
        public DeleteDistibutedCompanyEndPointResponse() { }
        public DeleteDistibutedCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
