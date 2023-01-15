using Pharmacy.Core.UserManagement;
using Phone_Book.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class LoginEndPointResponse : BaseResponse
    {
        public LoginEndPointResponse() { }
        public LoginEndPointResponse(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }
    }
}
