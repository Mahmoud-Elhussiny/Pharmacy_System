

using Pharmacy.Application.Business.Crud_representer.Query;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class GetAllRepresentersEndPointResponse : BaseResponse
    {
        public GetAllRepresentersEndPointResponse() { }
        public GetAllRepresentersEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<All_Representers> all_Representers { get; set; }

    }
}
