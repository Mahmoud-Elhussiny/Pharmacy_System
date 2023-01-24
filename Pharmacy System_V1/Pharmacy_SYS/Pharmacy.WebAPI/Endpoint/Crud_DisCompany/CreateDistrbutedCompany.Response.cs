using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class CreateDistrbutedCompanyEndPointResponse : BaseRessponse
    {
        public CreateDistrbutedCompanyEndPointResponse() { }
        public CreateDistrbutedCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
