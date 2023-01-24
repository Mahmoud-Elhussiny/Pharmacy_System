using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Create_CalenderHandler : IRequestHandler<Create_CalenderHandlerInput, Create_CalenderHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Create_CalenderHandler> _logger;
        public Create_CalenderHandler(ILogger<Create_CalenderHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Create_CalenderHandlerOutput> Handle(Create_CalenderHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Create_Calender business logic");
            Create_CalenderHandlerOutput output = new Create_CalenderHandlerOutput(request.CorrelationId());

            var newCalender = new Calenders();

            newCalender.NameEn = request.NameEn.Trim();
            newCalender.NameAr = request.NameAr.Trim();

            await _databaseService.Calenders.AddAsync(newCalender, cancellationToken);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new WebApiException("Can't Save Data ");

            output.Message = "Data Saved Successfully";

            return output;
        }
    }
}
