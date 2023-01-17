using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.Services;
using Pharmacy.Core.UserManagement;
using Pharmacy.domain;
using System.Text;

namespace Pharmacy.Application.Business.UserManagment.Reset_Password
{
    public class ForgetPasswordHandler : IRequestHandler<ForgetPasswordHandlerInput, ForgetPasswordHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<ForgetPasswordHandler> _logger;
        private IConfiguration _configuration;
        private IMailService _mailService;
        private UserManager<ApplicationUser> _userManger;
        public ForgetPasswordHandler(ILogger<ForgetPasswordHandler> logger, 
            IDatabaseService databaseService,
            IHttpContextAccessor contextAccessor,
            IConfiguration configuration, IMailService mailService, UserManager<ApplicationUser> userManger)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _configuration = configuration;
            _mailService = mailService;
            _userManger = userManger;
        }
        public async Task<ForgetPasswordHandlerOutput> Handle(ForgetPasswordHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling ForgetPassword business logic");
            ForgetPasswordHandlerOutput output = new ForgetPasswordHandlerOutput(request.CorrelationId());
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

            var token = await _userManger.GeneratePasswordResetTokenAsync(user);
            var encodedToken = Encoding.UTF8.GetBytes(token);
            var validToken = WebEncoders.Base64UrlEncode(encodedToken);

            string url = $"{_configuration["AppUrl"]}/ResetPassword?email={request.email}&token={validToken}";

            await _mailService.SendEmailAsync(request.email, "Reset Password", "<h1>Follow the instructions to reset your password</h1>" +
                $"<p>To reset your password <a href='{url}'>Click here</a></p>");

            output.UserManagmentResponse= new UserManagementResponse
            {
                IsSuccess = true,
                Message = "Reset password URL has been sent to the email successfully!"
            };
           
            return output;
        }
    }
}
