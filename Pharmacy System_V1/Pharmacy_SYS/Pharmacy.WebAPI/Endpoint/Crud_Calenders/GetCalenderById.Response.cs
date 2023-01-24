
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class GetCalenderByIdEndPointResponse : BaseRessponse
    {
        public GetCalenderByIdEndPointResponse() { }
        public GetCalenderByIdEndPointResponse(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
