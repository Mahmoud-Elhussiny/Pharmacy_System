using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class LogoutEndPointResponse : BaseRessponse
    {
        public LogoutEndPointResponse() { }
        public LogoutEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
