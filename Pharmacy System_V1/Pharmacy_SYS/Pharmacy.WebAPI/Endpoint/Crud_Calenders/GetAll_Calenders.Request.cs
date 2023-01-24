using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class GetAll_CalendersEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetAll_Calenders/";
    }
}
