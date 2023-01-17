using Pharmacy.Application.Masseges;
using Pharmacy.Core.UserManagement;

namespace Pharmacy.Application.Business.UserManagment.Reset_Password
{
    public class ForgetPasswordHandlerOutput : BaseResponse
    {
        public ForgetPasswordHandlerOutput() { }
        public ForgetPasswordHandlerOutput(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }


    }
}
