using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Create_UnitsEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Create_Units/";
        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
