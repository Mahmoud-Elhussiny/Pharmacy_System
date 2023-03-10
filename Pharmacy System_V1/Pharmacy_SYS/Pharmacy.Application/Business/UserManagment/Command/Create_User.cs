using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.UserManagment.Query;
using Pharmacy.Application.Contract;
using Pharmacy.Core.UserManagement;
using Pharmacy.domain;
using System.Security.Claims;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class Create_UserHandler : IRequestHandler<Create_UserHandlerInput, Create_UserHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Create_UserHandler> _logger;
        private UserManager<ApplicationUser> _userManger;
        
        public Create_UserHandler(ILogger<Create_UserHandler> logger,
            IDatabaseService databaseService,
            IHttpContextAccessor contextAccessor ,
            UserManager<ApplicationUser> userManager
            )
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _userManger = userManager;
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
                timeCreated=DateTime.UtcNow,
                isAdmin=request.isAdmin
            };

            var result = await _userManger.CreateAsync(ApplicationUser, request.Password);


            await _userManger.AddClaimAsync(ApplicationUser, new Claim("FirstName", ApplicationUser.firstName));
            await _userManger.AddClaimAsync(ApplicationUser, new Claim("LastName", ApplicationUser.lastName));
            await _userManger.AddClaimAsync(ApplicationUser, new Claim("UserName", ApplicationUser.UserName));
            await _userManger.AddClaimAsync(ApplicationUser, new Claim(ClaimTypes.Email, ApplicationUser.Email));
            await _userManger.AddClaimAsync(ApplicationUser, new Claim("Id", ApplicationUser.Id));





            if (result.Succeeded)
            {

                output.UserManagmentResponse = new UserManagementResponse
                {
                    Message = "User Created Sucessfully",
                    IsSuccess = true,
                };
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
