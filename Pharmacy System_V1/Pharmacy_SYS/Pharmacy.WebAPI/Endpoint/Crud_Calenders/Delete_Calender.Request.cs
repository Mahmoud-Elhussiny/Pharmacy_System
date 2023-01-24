using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Delete_CalenderEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Delete_Calender/";

        public int Id { get; set; }


    }
}
