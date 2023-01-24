using Pharmacy.Application.Business.Crud_Items.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class GetAll_ItemsEndPointResponse : BaseRessponse
    {
        public GetAll_ItemsEndPointResponse() { }
        public GetAll_ItemsEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<AllItems> _AllItems { get; set; }

    }
}
