using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.Services;
using Pharmacy.Core.UserManagement;
using Pharmacy.domain;
using System.Text;

namespace Pharmacy.Application.Business.UserManagment.Reset_Password
{
    public class ResetPasswordHandler : IRequestHandler<ResetPasswordHandlerInput, ResetPasswordHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<ResetPasswordHandler> _logger;
        private IConfiguration _configuration;
        private UserManager<ApplicationUser> _userManger;
        public ResetPasswordHandler(ILogger<ResetPasswordHandler> logger,
            IDatabaseService databaseService,
            IHttpContextAccessor contextAccessor,
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _configuration = configuration;
            _userManger = userManager;

    }
        public async Task<ResetPasswordHandlerOutput> Handle(ResetPasswordHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling ResetPassword business logic");
            ResetPasswordHandlerOutput output = new ResetPasswordHandlerOutput(request.CorrelationId());
            var user = await _userManger.FindByNameAsync(request.userName);
            if (user == null)
            {
                output.UserManagmentResponse = new UserManagementResponse
                {
                    Message = "There Is No User With Associated UserName ",
                    IsSuccess = false,
                };
                return output;
            }
            if (request.NewPassword != request.ConfirmPassword)
            {
                output.UserManagmentResponse = new UserManagementResponse
                {
                    Message = "Password doesn't match its confirmation",
                    IsSuccess = false,
                };
                return output;

            }

            var decodedToken = WebEncoders.Base64UrlDecode(request.Token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await _userManger.ResetPasswordAsync(user, normalToken, request.NewPassword);

            if (result.Succeeded) {
                output.UserManagmentResponse = new UserManagementResponse
                {
                    Message = "Password has been reset successfully!",
                    IsSuccess = true,
                };
                return output;
                }

            output.UserManagmentResponse= new UserManagementResponse
            {
                Message = "Something went wrong",
                IsSuccess = false,
                Errors = result.Errors.Select(e => e.Description),
            };
            return output;
        }
    }
}
