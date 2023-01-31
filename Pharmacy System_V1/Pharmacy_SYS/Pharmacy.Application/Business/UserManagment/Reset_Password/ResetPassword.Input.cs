using MediatR;
using Pharmacy.Application.Masseges;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Pharmacy.Application.Business.UserManagment.Reset_Password
{
    public class ResetPasswordHandlerInput : BaseRequest, IRequest<ResetPasswordHandlerOutput>
    {
        public ResetPasswordHandlerInput() { }
        public ResetPasswordHandlerInput(Guid correlationId) : base(correlationId) { }
        [IgnoreDataMember]
        public string userName { get; set; }
        public string Token { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
    }
}
