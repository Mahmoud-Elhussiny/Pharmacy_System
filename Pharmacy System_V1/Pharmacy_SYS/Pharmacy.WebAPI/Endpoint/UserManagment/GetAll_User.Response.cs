using Pharmacy.Application.Business.UserManagment.Query;
using Pharmacy.Application.Masseges;
namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class GetAll_UserEndPointResponse : BaseRessponse
    {
        public GetAll_UserEndPointResponse() { }
        public GetAll_UserEndPointResponse(Guid correlationId) : base(correlationId) { }

        public List<listUsers> _users { get; set; }

    }
}
