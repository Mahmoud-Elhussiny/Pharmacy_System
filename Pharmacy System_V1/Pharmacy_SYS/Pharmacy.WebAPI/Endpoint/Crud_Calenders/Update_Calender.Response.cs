
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Update_CalenderEndPointResponse : BaseRessponse
    {
        public Update_CalenderEndPointResponse() { }
        public Update_CalenderEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string Message { get; set; }
    }
}
