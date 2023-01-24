using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Search_ItemTypeEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Search_ItemType/";

        public string? nameEn { get; set; }
        public string? nameAr { get; set; }
    }
}
