using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Units.Command
{
    public class Delete_UnitsHandler : IRequestHandler<Delete_UnitsHandlerInput, Delete_UnitsHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Delete_UnitsHandler> _logger;
        public Delete_UnitsHandler(ILogger<Delete_UnitsHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Delete_UnitsHandlerOutput> Handle(Delete_UnitsHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Delete_Units business logic");
            Delete_UnitsHandlerOutput output = new Delete_UnitsHandlerOutput(request.CorrelationId());
            var unitdeleted = await _databaseService.units.Where(o => o.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            if (unitdeleted == null)
            {
                throw new WebApiException("this Unit Is Not Found");
            }

            _databaseService.units.Remove(unitdeleted);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Can't deleted The Data");
            }

            output.message = "data Deleted successfully";

            return output;
        }
    }
}
