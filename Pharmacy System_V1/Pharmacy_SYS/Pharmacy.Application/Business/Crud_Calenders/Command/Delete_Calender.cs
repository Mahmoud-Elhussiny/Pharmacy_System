using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Delete_CalenderHandler : IRequestHandler<Delete_CalenderHandlerInput, Delete_CalenderHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Delete_CalenderHandler> _logger;
        public Delete_CalenderHandler(ILogger<Delete_CalenderHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Delete_CalenderHandlerOutput> Handle(Delete_CalenderHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Delete_Calender business logic");
            Delete_CalenderHandlerOutput output = new Delete_CalenderHandlerOutput(request.CorrelationId());

            var calenderDeleted = await _databaseService.Calenders
                .FirstOrDefaultAsync(o=>o.Id==request.Id,cancellationToken);

            if (calenderDeleted == null)
                throw new WebApiException("this Calender is not found");

            _databaseService.Calenders.Remove(calenderDeleted);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new WebApiException("Can't Deleted Data");

            output.Message = "Data Deleted Successfully";

            return output;
        }
    }
}
