using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class GetUnitByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetUnitById/";
        public int Id { get; set; }
    }
}
