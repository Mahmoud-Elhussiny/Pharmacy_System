using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Update_CalenderEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Update_Calender/";

        public int Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
    }
}
