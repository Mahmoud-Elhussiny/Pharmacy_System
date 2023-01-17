using Pharmacy.Application.Masseges;
using Pharmacy.Core.UserManagement;

namespace Pharmacy.Application.Business.UserManagment.Reset_Password
{
    public class ResetPasswordHandlerOutput : BaseResponse
    {
        public ResetPasswordHandlerOutput() { }
        public ResetPasswordHandlerOutput(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }


    }
}
