using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Update_CalenderHandler : IRequestHandler<Update_CalenderHandlerInput, Update_CalenderHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Update_CalenderHandler> _logger;
        public Update_CalenderHandler(ILogger<Update_CalenderHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Update_CalenderHandlerOutput> Handle(Update_CalenderHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Update_Calender business logic");
            Update_CalenderHandlerOutput output = new Update_CalenderHandlerOutput(request.CorrelationId());

            var calenderUpdated =await _databaseService.Calenders.Where(o=>o.Id==request.Id).FirstOrDefaultAsync(cancellationToken);

            if (calenderUpdated == null)
                throw new WebApiException("this Calender is not found");

            if (!String.IsNullOrEmpty(request.NameEn))
            {
                calenderUpdated.NameEn = request.NameEn.Trim();
            }
            if (!String.IsNullOrEmpty(request.NameAr))
            {
                calenderUpdated.NameAr = request.NameAr.Trim();
            }

            _databaseService.Calenders.Update(calenderUpdated);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new WebApiException("Can't Updated Data ");

            output.Message = "Data Updated Successfully";

            return output;
        }
    }
}
