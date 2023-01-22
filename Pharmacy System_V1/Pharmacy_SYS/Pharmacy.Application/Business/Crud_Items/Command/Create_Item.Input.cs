using MediatR;
using Pharmacy.Application.Masseges;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Create_ItemHandlerInput : BaseRequest, IRequest<Create_ItemHandlerOutput>
    {
        public Create_ItemHandlerInput() { }
        public Create_ItemHandlerInput(Guid correlationId) : base(correlationId) { }

        public string tradeNameEn { get; set; } = "";
        public string tradeNameAr { get; set; } = "";
        public string chemicalName { get; set; } = "";
        public string Code { get; set; } = null!;
        public string batchNo { get; set; } = null!;
        public int? molality { get; set; }
        public int duration { get; set; }
        public decimal? buyingPrice { get; set; }
        public decimal? sellingPrice { get; set; }
        public int? itemtypeId { get; set; }
        public int? manufactureId { get; set; }
        public int? distributedId { get; set; }
        public int? clenderId { get; set; }


    }
}
