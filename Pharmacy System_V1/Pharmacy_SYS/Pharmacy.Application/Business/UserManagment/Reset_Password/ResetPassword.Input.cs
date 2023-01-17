using MediatR;
using Pharmacy.Application.Masseges;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Application.Business.UserManagment.Reset_Password
{
    public class ResetPasswordHandlerInput : BaseRequest, IRequest<ResetPasswordHandlerOutput>
    {
        public ResetPasswordHandlerInput() { }
        public ResetPasswordHandlerInput(Guid correlationId) : base(correlationId) { }
        public string Token { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string userName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string NewPassword { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string ConfirmPassword { get; set; }
    }
}
