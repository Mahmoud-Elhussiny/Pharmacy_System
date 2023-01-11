using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class Create_UserHandler : IRequestHandler<Create_UserHandlerInput, Create_UserHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Create_UserHandler> _logger;
        public Create_UserHandler(ILogger<Create_UserHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Create_UserHandlerOutput> Handle(Create_UserHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Create_User business logic");
            Create_UserHandlerOutput output = new Create_UserHandlerOutput(request.CorrelationId());
            
            await Task.CompletedTask;
            return output;
        }
    }
}
