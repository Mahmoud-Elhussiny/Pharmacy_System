using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Update_UnitsEndPointResponse : BaseResponse
    {
        public Update_UnitsEndPointResponse() { }
        public Update_UnitsEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string message { get; set; }

    }
}
