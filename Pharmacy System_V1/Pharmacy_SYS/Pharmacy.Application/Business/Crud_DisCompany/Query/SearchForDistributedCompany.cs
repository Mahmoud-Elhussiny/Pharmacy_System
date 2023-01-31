using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_DisCompany.Query
{
    public class SearchForDistributedCompanyHandler : IRequestHandler<SearchForDistributedCompanyHandlerInput, SearchForDistributedCompanyHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<SearchForDistributedCompanyHandler> _logger;
        public SearchForDistributedCompanyHandler(ILogger<SearchForDistributedCompanyHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<SearchForDistributedCompanyHandlerOutput> Handle(SearchForDistributedCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling SearchForDistributedCompany business logic");
            SearchForDistributedCompanyHandlerOutput output = new SearchForDistributedCompanyHandlerOutput(request.CorrelationId());
            var allditributedcompanies = await _databaseService.distributedCompanies.ToListAsync(cancellationToken);
            if (!allditributedcompanies.Any())
            {
                throw new WebApiException("There Are No Items In This List");
            }
            if (request.Id.HasValue && request.Id.Value != 0)
                allditributedcompanies = await _databaseService.distributedCompanies.Where(i => i.Id == request.Id).ToListAsync(cancellationToken);
            if (!string.IsNullOrEmpty(request.NameAr))
                allditributedcompanies = await _databaseService.distributedCompanies.Where(n => n.NameAr.Contains(request.NameAr.Trim())).ToListAsync(cancellationToken);
            if (!string.IsNullOrEmpty(request.NameEn))
                allditributedcompanies = await _databaseService.distributedCompanies.Where(E => E.NameEn.Contains(request.NameEn.Trim())).ToListAsync(cancellationToken);
            if (request.TheManufacturerId.HasValue && request.TheManufacturerId.Value != 0)
                allditributedcompanies = await _databaseService.distributedCompanies.Where(i => i.TheManufacturerId == request.TheManufacturerId).ToListAsync(cancellationToken);
            output.distributedCompanies = allditributedcompanies.Select(c => new All_DistributedCompanies
            {
                Id = c.Id,
                NameAr = c.NameAr,
                NameEn = c.NameEn,
                Location = c.Location,
                Phone = c.Phone,
                TheManufacturerId=c.TheManufacturerId,
            }).ToList();
            return output;
        }
    }
}
