using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Query
{
    public class SearchForUserHandlerInput : BaseRequest, IRequest<SearchForUserHandlerOutput>
    {
        public SearchForUserHandlerInput() { }
        public SearchForUserHandlerInput(Guid correlationId) : base(correlationId) { }
        public string? firstName { get; set; }
        //public string? lastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public int? isAdmin { get; set; }
    }
}
