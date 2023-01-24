using Pharmacy.Application.Business.UserManagment.Query;
using Pharmacy.Application.Masseges;
namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class SearchForUserEndPointResponse : BaseRessponse
    {
        public SearchForUserEndPointResponse() { }
        public SearchForUserEndPointResponse(Guid correlationId) : base(correlationId) { }
        public List<PH_Users>? phUsers { get; set; }


    }
}
