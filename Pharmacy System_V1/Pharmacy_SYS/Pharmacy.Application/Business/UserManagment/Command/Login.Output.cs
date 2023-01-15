using Pharmacy.Core.UserManagement;
using Phone_Book.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LoginHandlerOutput : BaseResponse
    {
        public LoginHandlerOutput() { }
        public LoginHandlerOutput(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }
    }
}
