using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class GetDistributedCompanyByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetDistributedCompanyById/";
        public int Id { get; set; }
    }
}
