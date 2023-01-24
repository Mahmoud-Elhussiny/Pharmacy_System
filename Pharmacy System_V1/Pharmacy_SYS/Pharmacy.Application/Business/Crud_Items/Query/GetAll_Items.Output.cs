using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Items.Query
{
    public class GetAll_ItemsHandlerOutput : BaseRessponse
    {
        public GetAll_ItemsHandlerOutput() { }
        public GetAll_ItemsHandlerOutput(Guid correlationId) : base(correlationId) { }
        public List<AllItems> _AllItems { get; set; }
    }

    
    public class AllItems
    {
        public int Id { get; set; }
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
