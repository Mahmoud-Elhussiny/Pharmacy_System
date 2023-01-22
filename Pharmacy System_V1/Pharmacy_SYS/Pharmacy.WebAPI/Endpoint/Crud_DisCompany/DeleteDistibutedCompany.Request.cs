using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class DeleteDistibutedCompanyEndPointRequest : BaseRequest
    {
        public const string Route = "/api/DeleteDistibutedCompany/";
        public int Id { get; set; }
    }
}
