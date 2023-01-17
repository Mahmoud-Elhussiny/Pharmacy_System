using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.UserManagment.Query
{
    public class GetUserByUserNameHandler : IRequestHandler<GetUserByUserNameHandlerInput, GetUserByUserNameHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetUserByUserNameHandler> _logger;
        private UserManager<ApplicationUser> _userManger;

        public GetUserByUserNameHandler(ILogger<GetUserByUserNameHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor, UserManager<ApplicationUser>userManager)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _userManger = userManager;
        }
        public async Task<GetUserByUserNameHandlerOutput> Handle(GetUserByUserNameHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetUserByUserName business logic");
            GetUserByUserNameHandlerOutput output = new GetUserByUserNameHandlerOutput(request.CorrelationId());
            var user = _databaseService.AppUser.FirstOrDefault(u => u.UserName == request.userName);
            if (user == null)
            {
                throw new WebApiException("User Not Found");
            }
            output.UserName = user.UserName;
            output.firstName = user.firstName;
            output.lastName = user.lastName;
            output.Phone1 = user.Phone1;
            output.Phone2 = user.Phone2;
            output.Address = user.Address;
            output.Email = user.Email;
            output.isActive = user.isActive;
            output.isAdmin = user.isAdmin;
            output.Picture = user.Picture;
            output.lastloginDate = user.lastloginDate;
            output.timeCreated = user.timeCreated;
            return output;
        }
    }
}
