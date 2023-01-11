using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;


namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LoginHandler : IRequestHandler<LoginHandlerInput, LoginHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<LoginHandler> _logger;
        public LoginHandler(ILogger<LoginHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<LoginHandlerOutput> Handle(LoginHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Login business logic");
            LoginHandlerOutput output = new LoginHandlerOutput(request.CorrelationId());
            await Task.CompletedTask;
            return output;
        }
    }
}
