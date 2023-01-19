using Pharmacy.Application.Business.Crud_ItemTypes.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class GetAll_ItemTypeEndPointResponse : BaseResponse
    {
        public GetAll_ItemTypeEndPointResponse() { }
        public GetAll_ItemTypeEndPointResponse(Guid correlationId) : base(correlationId) { }

        public List<listItemtype> listItemtypes { get; set; }
    }
}
