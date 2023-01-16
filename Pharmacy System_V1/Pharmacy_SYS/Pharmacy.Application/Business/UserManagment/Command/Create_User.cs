using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.Services;
using Pharmacy.Core.UserManagement;
using Pharmacy.domain;


namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class Create_UserHandler : IRequestHandler<Create_UserHandlerInput, Create_UserHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Create_UserHandler> _logger;
        private UserManager<ApplicationUser> _userManger;
        private readonly IConfirmEmail _confirmEmail;

        public Create_UserHandler(ILogger<Create_UserHandler> logger,
            IDatabaseService databaseService,
            IHttpContextAccessor contextAccessor ,
            UserManager<ApplicationUser> userManager,
            IConfirmEmail confirmEmail
            )
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _userManger = userManager;
            _confirmEmail = confirmEmail;
        }
        public async Task<Create_UserHandlerOutput> Handle(Create_UserHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Create_User business logic");
            Create_UserHandlerOutput output = new Create_UserHandlerOutput(request.CorrelationId());


            if (request.Password != request.ConfirmPassword)
            {
                output.UserManagmentResponse = new UserManagementResponse
                {
                    Message = "Confirm password doesn't match the password",
                    IsSuccess = false,
                };
                return output;  
            }

            var ApplicationUser = new ApplicationUser
            {
                firstName=request.firstName!,
                lastName=request.lastName!,
                UserName=request.UserName,
                Phone1=request.Phone1,
                Phone2=request.Phone2,
                Address=request.Address,
                Email=request.Email,
                isAdmin=request.isAdmin
            };

            var result = await _userManger.CreateAsync(ApplicationUser, request.Password);

            if (result.Succeeded)
            {

                output.UserManagmentResponse = new UserManagementResponse
                {
                    Message = "User Created Sucessfully",
                    IsSuccess = true,
                };
                await _confirmEmail.sendEmailAsync(request.Email, "new create user",
                    "create new user", "<h1>New User Is Created In Pharmacy System</h1>");
                return output;
            }


            output.UserManagmentResponse = new UserManagementResponse
            {
                Message = "User did not create",
                IsSuccess = false,
                Errors = result.Errors.Select(e => e.Description)
            };

            return output;
        }
    }
}
