using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Create_CalenderEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Create_Calender/";
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
