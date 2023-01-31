using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LogoutHandler : IRequestHandler<LogoutHandlerInput, LogoutHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<LogoutHandler> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LogoutHandler(ILogger<LogoutHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor,SignInManager<ApplicationUser> signInManager)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _signInManager = signInManager;
        
        }
        public async Task<LogoutHandlerOutput> Handle(LogoutHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Logout business logic");
            LogoutHandlerOutput output = new LogoutHandlerOutput(request.CorrelationId());
            await _signInManager.SignOutAsync();
            output.Message = "Logged Out Sucessfully";
            return output;
        }
    }
}
