using Pharmacy.Application.Masseges;
using Pharmacy.Core.UserManagement;

namespace Pharmacy.Application.Business.UserManagment.Reset_Password
{
    public class ResetPasswordHandlerOutput : BaseRessponse
    {
        public ResetPasswordHandlerOutput() { }
        public ResetPasswordHandlerOutput(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }


    }
}
