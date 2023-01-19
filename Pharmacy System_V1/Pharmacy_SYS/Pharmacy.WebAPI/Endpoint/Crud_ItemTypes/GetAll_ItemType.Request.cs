using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class GetAll_ItemTypeEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetAll_ItemType/";
    }
}
