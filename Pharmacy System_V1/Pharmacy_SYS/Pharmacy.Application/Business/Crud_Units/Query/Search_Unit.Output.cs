using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class Search_UnitHandlerOutput : BaseResponse
    {
        public Search_UnitHandlerOutput() { }
        public Search_UnitHandlerOutput(Guid correlationId) : base(correlationId) { }

        public List<SearchlistofUnit> searchlistofUnits { get; set; }
    }

    public class SearchlistofUnit
    {
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
