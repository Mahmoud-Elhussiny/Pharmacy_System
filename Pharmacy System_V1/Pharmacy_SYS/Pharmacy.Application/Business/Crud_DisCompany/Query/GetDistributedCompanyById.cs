using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_DisCompany.Query
{
    public class GetDistributedCompanyByIdHandler : IRequestHandler<GetDistributedCompanyByIdHandlerInput, GetDistributedCompanyByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetDistributedCompanyByIdHandler> _logger;
        public GetDistributedCompanyByIdHandler(ILogger<GetDistributedCompanyByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetDistributedCompanyByIdHandlerOutput> Handle(GetDistributedCompanyByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetDistributedCompanyById business logic");
            GetDistributedCompanyByIdHandlerOutput output = new GetDistributedCompanyByIdHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var distributedCompany = await _databaseService.distributedCompanies.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (distributedCompany == null)
            {
                throw new WebApiException("The Distributed Company Not Found");
            }
            output.Id = distributedCompany.Id;
            output.NameAr = distributedCompany.NameAr;
            output.NameEn = distributedCompany.NameEn;
            output.Location = distributedCompany.Location;
            output.Phone = distributedCompany.Phone;
            output.TheManufacturerId= distributedCompany.TheManufacturerId;
            return output;
        }
    }
}
