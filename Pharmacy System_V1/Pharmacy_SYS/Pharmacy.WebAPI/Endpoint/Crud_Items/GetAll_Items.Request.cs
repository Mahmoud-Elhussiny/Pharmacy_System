using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class GetAll_ItemsEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetAll_Items/";
    }
}
