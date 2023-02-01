using Pharmacy.Application.Business.Crud_Calenders.Quary;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Search_CalenderEndPointResponse : BaseResponse
    {
        public Search_CalenderEndPointResponse() { }
        public Search_CalenderEndPointResponse(Guid correlationId) : base(correlationId) { }

        public List<SeachlistOfCalender> resultcalenders { get; set; }

    }
}
