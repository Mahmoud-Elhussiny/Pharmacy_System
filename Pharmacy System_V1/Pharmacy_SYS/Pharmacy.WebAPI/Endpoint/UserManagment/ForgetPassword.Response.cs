using Pharmacy.Application.Masseges;
using Pharmacy.Core.UserManagement;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class ForgetPasswordEndPointResponse : BaseResponse
    {
        public ForgetPasswordEndPointResponse() { }
        public ForgetPasswordEndPointResponse(Guid correlationId) : base(correlationId) { }
        public UserManagementResponse UserManagmentResponse { get; set; }


    }
}
