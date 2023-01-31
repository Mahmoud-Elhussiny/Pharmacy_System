using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class SearchForManufacturerHandler : IRequestHandler<SearchForManufacturerHandlerInput, SearchForManufacturerHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<SearchForManufacturerHandler> _logger;
        public SearchForManufacturerHandler(ILogger<SearchForManufacturerHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<SearchForManufacturerHandlerOutput> Handle(SearchForManufacturerHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling SearchForManufacturer business logic");
            SearchForManufacturerHandlerOutput output = new SearchForManufacturerHandlerOutput(request.CorrelationId());
            var allManufacturers = await _databaseService.TheManufacturer.ToListAsync(cancellationToken);
            if (!allManufacturers.Any())
            {
                throw new WebApiException("There Are No Items In This List");
            }
            if(request.Id.HasValue && request.Id.Value!= 0)
                allManufacturers = await _databaseService.TheManufacturer.Where(i=>i.Id==request.Id).ToListAsync(cancellationToken);
            if(!string.IsNullOrEmpty(request.NameAr))
                allManufacturers=await _databaseService.TheManufacturer.Where(n=>n.NameAr.Contains(request.NameAr.Trim())).ToListAsync(cancellationToken);
            if(!string.IsNullOrEmpty(request.NameEn))
                allManufacturers=await _databaseService.TheManufacturer.Where(E=>E.NameEn.Contains(request.NameEn.Trim())).ToListAsync(cancellationToken);
            output.allManufacturers = allManufacturers.Select(c => new AllManufacturers
            {
                Id = c.Id,
                NameAr = c.NameAr,
                NameEn = c.NameEn,
                Location = c.Location,
                Phone = c.Phone
            }).ToList();
            return output;
        }
    }
}
