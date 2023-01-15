
using Pharmacy.Core.UserManagement;
using Phone_Book.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class Create_UserEndPointResponse : BaseResponse
    {
        public Create_UserEndPointResponse() { }
        public Create_UserEndPointResponse(Guid correlationId) : base(correlationId) { }

        public UserManagementResponse UserManagmentResponse { get; set; }


    }
}
