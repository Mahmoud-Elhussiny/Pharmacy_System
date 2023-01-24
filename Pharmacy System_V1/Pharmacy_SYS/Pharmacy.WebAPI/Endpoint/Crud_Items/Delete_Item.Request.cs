using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Delete_ItemEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Delete_Item/";


        public int Id { get; set; }
    }
}
