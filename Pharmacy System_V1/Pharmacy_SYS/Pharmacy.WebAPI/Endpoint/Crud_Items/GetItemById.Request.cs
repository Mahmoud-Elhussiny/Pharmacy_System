using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class GetItemByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetItemById/";

        public int Id { get; set; }
    }
}
