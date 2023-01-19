using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class GetAll_UnitsHandler : IRequestHandler<GetAll_UnitsHandlerInput, GetAll_UnitsHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAll_UnitsHandler> _logger;
        public GetAll_UnitsHandler(ILogger<GetAll_UnitsHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAll_UnitsHandlerOutput> Handle(GetAll_UnitsHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAll_Units business logic");
            GetAll_UnitsHandlerOutput output = new GetAll_UnitsHandlerOutput(request.CorrelationId());
            var allunits = await _databaseService.units.Select(o => new listofUnit
            {
                Id = o.Id,
                nameEn = o.nameEn,
                nameAr = o.nameAr
            }).ToListAsync(cancellationToken);

            output.listofUnits = allunits;

            return output;
        }
    }
}
