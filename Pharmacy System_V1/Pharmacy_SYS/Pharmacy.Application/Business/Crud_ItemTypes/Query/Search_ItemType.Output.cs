using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class Search_ItemTypeHandlerOutput : BaseRessponse
    {
        public Search_ItemTypeHandlerOutput() { }
        public Search_ItemTypeHandlerOutput(Guid correlationId) : base(correlationId) { }

        public List<SearchlistItemtype> searchlistItemtypes { get; set; }
    }

    public class SearchlistItemtype
    {
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }

    }
}
