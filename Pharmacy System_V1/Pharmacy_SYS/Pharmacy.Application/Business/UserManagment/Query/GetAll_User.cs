using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.UserManagment.Query
{
    public class GetAll_UserHandler : IRequestHandler<GetAll_UserHandlerInput, GetAll_UserHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAll_UserHandler> _logger;
        private UserManager<ApplicationUser> _userManger;

        public GetAll_UserHandler(ILogger<GetAll_UserHandler> logger, 
            IDatabaseService databaseService, 
            IHttpContextAccessor contextAccessor, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _userManger = userManager;
        }
        public async Task<GetAll_UserHandlerOutput> Handle(GetAll_UserHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAll_User business logic");
            GetAll_UserHandlerOutput output = new GetAll_UserHandlerOutput(request.CorrelationId());
            var allusers = await _userManger.Users.Select(o => new listUsers
            {
                firstName = o.firstName,
                lastName = o.lastName,
                UserName = o.UserName,
                Address = o.Address,
                Email = o.Email,
                Phone1 = o.Phone1,
                Phone2 = o.Phone2,
                lastloginDate = (DateTime)o.lastloginDate!,
                timeCreated = (DateTime)o.timeCreated!,

            }).ToListAsync();

            output._users = allusers;
            return output;
        }
    }
}
