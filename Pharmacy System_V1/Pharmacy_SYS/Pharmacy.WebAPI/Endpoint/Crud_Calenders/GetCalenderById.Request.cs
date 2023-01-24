using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class GetCalenderByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetCalenderById/";


        public int Id { get; set; }
    }
}
