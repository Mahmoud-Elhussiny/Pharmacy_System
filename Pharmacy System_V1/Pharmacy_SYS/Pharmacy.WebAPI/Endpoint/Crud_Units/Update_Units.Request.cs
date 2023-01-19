using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Update_UnitsEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Update_Units/";
        public int Id { get; set; }
        public string? nameEn { get; set; }
        public string? nameAr { get; set; }
    }
}
