using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Update_ItemHandlerInput : BaseRequest, IRequest<Update_ItemHandlerOutput>
    {
        public Update_ItemHandlerInput() { }
        public Update_ItemHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public string? tradeNameEn { get; set; }
        public string? tradeNameAr { get; set; }
        public string? chemicalName { get; set; }
        public string? Code { get; set; }
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
