using Pharmacy.Application.Masseges;
using Pharmacy.Core.UserManagement;
namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LoginHandlerOutput : BaseRessponse
    {
        public LoginHandlerOutput() { }
        public LoginHandlerOutput(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }
    }
}
