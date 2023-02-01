using Pharmacy.Application.Masseges;
using Pharmacy.Core.UserManagement;
namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class LoginEndPointResponse : BaseResponse
    {
        public LoginEndPointResponse() { }
        public LoginEndPointResponse(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }
    }
}
