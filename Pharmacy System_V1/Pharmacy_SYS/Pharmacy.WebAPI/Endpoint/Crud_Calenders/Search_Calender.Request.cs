using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Search_CalenderEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Search_Calender/";

        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
    }
}
