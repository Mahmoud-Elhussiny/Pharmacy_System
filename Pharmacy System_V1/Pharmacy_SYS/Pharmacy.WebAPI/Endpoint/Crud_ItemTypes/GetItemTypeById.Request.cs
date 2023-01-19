using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class GetItemTypeByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetItemTypeById/";

        public int Id { get; set; }

    }
}
