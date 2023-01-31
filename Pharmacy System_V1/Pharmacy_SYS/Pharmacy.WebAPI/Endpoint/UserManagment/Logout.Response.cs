using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class LogoutEndPointResponse : BaseResponse
    {
        public LogoutEndPointResponse() { }
        public LogoutEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
