using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Units.Command
{
    public class Update_UnitsHandler : IRequestHandler<Update_UnitsHandlerInput, Update_UnitsHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Update_UnitsHandler> _logger;
        public Update_UnitsHandler(ILogger<Update_UnitsHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Update_UnitsHandlerOutput> Handle(Update_UnitsHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Update_Units business logic");
            Update_UnitsHandlerOutput output = new Update_UnitsHandlerOutput(request.CorrelationId());

            var unitupdated = await _databaseService.units.Where(o => o.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            if(unitupdated == null)
            {
                throw new WebApiException("this Unit Is Not Found");
            }

            if (!String.IsNullOrEmpty(request.nameEn))
            {
                unitupdated.nameEn = request.nameEn;
            }
            if (!String.IsNullOrEmpty(request.nameAr))
            {
                unitupdated.nameAr = request.nameAr;
            }

            _databaseService.units.Update(unitupdated);

            if(await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Can't updated The Data");
            }

            output.message = "data Updated successfully";

            return output;
        }
    }
}
