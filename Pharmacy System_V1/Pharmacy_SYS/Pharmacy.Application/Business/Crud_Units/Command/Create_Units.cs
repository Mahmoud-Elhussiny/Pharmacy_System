using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_Units.Command
{
    public class Create_UnitsHandler : IRequestHandler<Create_UnitsHandlerInput, Create_UnitsHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Create_UnitsHandler> _logger;
        public Create_UnitsHandler(ILogger<Create_UnitsHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Create_UnitsHandlerOutput> Handle(Create_UnitsHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Create_Units business logic");
            Create_UnitsHandlerOutput output = new Create_UnitsHandlerOutput(request.CorrelationId());

            var newunit = new Units();

            newunit.nameEn = request.nameEn;
            newunit.nameAr = request.nameAr;


            await _databaseService.units.AddAsync(newunit, cancellationToken);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Can't Saving Data");
            }

            output.message = "Data Created Successfully";


            return output;
        }
    }
}
