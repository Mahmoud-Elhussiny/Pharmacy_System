

using Pharmacy.Core.UserManagement;
using Phone_Book.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class Create_UserHandlerOutput : BaseResponse
    {
        public Create_UserHandlerOutput() { }
        public Create_UserHandlerOutput(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }

    }
}
