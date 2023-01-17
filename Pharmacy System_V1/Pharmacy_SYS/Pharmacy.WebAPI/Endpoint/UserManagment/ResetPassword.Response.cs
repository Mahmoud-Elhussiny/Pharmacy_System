using Informatique.Base.Core.Messages;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class ResetPasswordEndPointResponse : BaseResponse
    {
        public ResetPasswordEndPointResponse() { }
        public ResetPasswordEndPointResponse(Guid correlationId) : base(correlationId) { }

    }
}
