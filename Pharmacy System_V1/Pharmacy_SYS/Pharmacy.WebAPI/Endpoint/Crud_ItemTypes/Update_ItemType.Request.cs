using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Update_ItemTypeEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Update_ItemType/";

        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }

    }
}
