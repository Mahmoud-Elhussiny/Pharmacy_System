using Pharmacy.Application.Business.Crud_Items.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Search_ItemEndPointResponse : BaseResponse
    {
        public Search_ItemEndPointResponse() { }
        public Search_ItemEndPointResponse(Guid correlationId) : base(correlationId) { }

        public List<SearchAllItems> SearchAllItem { get; set; }

    }
}
