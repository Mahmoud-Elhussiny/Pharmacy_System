using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Create_ItemTypeEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Create_ItemType/";

        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
