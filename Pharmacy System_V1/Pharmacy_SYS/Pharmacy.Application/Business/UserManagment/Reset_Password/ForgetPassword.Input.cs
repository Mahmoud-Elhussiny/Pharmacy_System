using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Reset_Password
{
    public class ForgetPasswordHandlerInput : BaseRequest, IRequest<ForgetPasswordHandlerOutput>
    {
        public ForgetPasswordHandlerInput() { }
        public ForgetPasswordHandlerInput(Guid correlationId) : base(correlationId) { }
        public string email { get; set; }
        public string userName { get; set; }
    }
}
