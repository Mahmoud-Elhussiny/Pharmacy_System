using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Search_UnitEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Search_Unit/";

        public string? nameEn { get; set; }
        public string? nameAr { get; set; }
    }
}
