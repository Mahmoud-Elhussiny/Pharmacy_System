using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class ResetPasswordEndPointResponse : BaseRessponse
    {
        public ResetPasswordEndPointResponse() { }
        public ResetPasswordEndPointResponse(Guid correlationId) : base(correlationId) { }

    }
}
