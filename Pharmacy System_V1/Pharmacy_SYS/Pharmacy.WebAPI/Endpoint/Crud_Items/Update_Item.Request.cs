using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Update_ItemEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Update_Item/";

        public int Id { get; set; }
        public string? tradeNameEn { get; set; } = "";
        public string? tradeNameAr { get; set; } = "";
        public string? chemicalName { get; set; } = "";
        public string? Code { get; set; } = null!;
        public int? molality { get; set; }
        public int? duration { get; set; }
        public decimal? buyingPrice { get; set; }
        public decimal? sellingPrice { get; set; }
        public int? itemtypeId { get; set; }
        public int? manufactureId { get; set; }
        public int? distributedId { get; set; }
        public int? clenderId { get; set; }
    }
}
