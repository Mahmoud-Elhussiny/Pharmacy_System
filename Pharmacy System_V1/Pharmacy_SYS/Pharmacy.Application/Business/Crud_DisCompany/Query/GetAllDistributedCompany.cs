using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_DisCompany.Query
{
    public class GetAllDistributedCompanyHandler : IRequestHandler<GetAllDistributedCompanyHandlerInput, GetAllDistributedCompanyHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAllDistributedCompanyHandler> _logger;
        public GetAllDistributedCompanyHandler(ILogger<GetAllDistributedCompanyHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAllDistributedCompanyHandlerOutput> Handle(GetAllDistributedCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAllDistributedCompany business logic");
            GetAllDistributedCompanyHandlerOutput output = new GetAllDistributedCompanyHandlerOutput(request.CorrelationId());
            var all_distributedcompanies = await _databaseService.distributedCompanies.ToListAsync(cancellationToken);
            output.allDistributedCompanies = all_distributedcompanies.Select(c => new AllDistributedCompanies
            {
                Id = c.Id,
                NameAr = c.NameAr,
                NameEn = c.NameEn,
                Location = c.Location,
                Phone = c.Phone,
                TheManufacturerId=c.TheManufacturerId

            }).ToList();
            return output;
        }
    }
}
