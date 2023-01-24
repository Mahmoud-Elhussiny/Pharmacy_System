
using Pharmacy.Application.Masseges;
using Pharmacy.Core.UserManagement;
namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class Create_UserEndPointResponse : BaseRessponse
    {
        public Create_UserEndPointResponse() { }
        public Create_UserEndPointResponse(Guid correlationId) : base(correlationId) { }

        public UserManagementResponse UserManagmentResponse { get; set; }


    }
}
