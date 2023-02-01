using Pharmacy.Application.Business.Crud_ItemTypes.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Search_ItemTypeEndPointResponse : BaseResponse
    {
        public Search_ItemTypeEndPointResponse() { }
        public Search_ItemTypeEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<SearchlistItemtype> searchlistItemtypes { get; set; }

    }
}
