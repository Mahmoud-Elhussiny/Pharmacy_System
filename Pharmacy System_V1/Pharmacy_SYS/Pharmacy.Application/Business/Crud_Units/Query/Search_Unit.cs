using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class Search_UnitHandler : IRequestHandler<Search_UnitHandlerInput, Search_UnitHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Search_UnitHandler> _logger;
        public Search_UnitHandler(ILogger<Search_UnitHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Search_UnitHandlerOutput> Handle(Search_UnitHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Search_Unit business logic");
            Search_UnitHandlerOutput output = new Search_UnitHandlerOutput(request.CorrelationId());

            var allunits = await _databaseService.units.Select(o => new SearchlistofUnit
            {
                Id = o.Id,
                nameEn = o.nameEn,
                nameAr = o.nameAr
            }).ToListAsync(cancellationToken);

            if (!String.IsNullOrEmpty(request.nameEn))
                allunits = allunits.Where(o => o.nameEn.StartsWith(request.nameEn.Trim())).ToList();

            if (!String.IsNullOrEmpty(request.nameAr))
                allunits = allunits.Where(o => o.nameAr.StartsWith(request.nameAr.Trim())).ToList();

            output.searchlistofUnits = allunits;

            return output;
        }
    }
}
