using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Delete_ItemTypeEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Delete_ItemType/";

        public int Id { get; set; }
    }
}
