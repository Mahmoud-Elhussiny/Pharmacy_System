using Pharmacy.Application.Masseges;
using Pharmacy.Core.UserManagement;
namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class Create_UserHandlerOutput : BaseRessponse
    {
        public Create_UserHandlerOutput() { }
        public Create_UserHandlerOutput(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }

    }
}
