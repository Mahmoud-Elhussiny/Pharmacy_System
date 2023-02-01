
using Pharmacy.Application.Business.Crud_Calenders.Quary;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class GetAll_CalendersEndPointResponse : BaseResponse
    {
        public GetAll_CalendersEndPointResponse() { }
        public GetAll_CalendersEndPointResponse(Guid correlationId) : base(correlationId) { }



        public List<listOfCalender> listOfCalenders { get; set; }

    }
}
