using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class UpdateDistributedCompanyHandler : IRequestHandler<UpdateDistributedCompanyHandlerInput, UpdateDistributedCompanyHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<UpdateDistributedCompanyHandler> _logger;
        public UpdateDistributedCompanyHandler(ILogger<UpdateDistributedCompanyHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<UpdateDistributedCompanyHandlerOutput> Handle(UpdateDistributedCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling UpdateDistributedCompany business logic");
            UpdateDistributedCompanyHandlerOutput output = new UpdateDistributedCompanyHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var oldDistributedCompany = await _databaseService.distributedCompanies.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (oldDistributedCompany == null)
            {
                throw new WebApiException("The Manufacturer Not Found");
            }
            if (!string.IsNullOrEmpty(request.NameAr))
                oldDistributedCompany.NameAr = request.NameAr.Trim();
            if (!string.IsNullOrEmpty(request.NameEn))
                oldDistributedCompany.NameEn = request.NameEn.Trim();
            if (!string.IsNullOrEmpty(request.Location))
                oldDistributedCompany.Location = request.Location;
            if (!string.IsNullOrEmpty(request.Phone))
                oldDistributedCompany.Phone = request.Phone;
            if(request.TheManufacturerId.HasValue&& request.TheManufacturerId.Value!=0)
            _databaseService.distributedCompanies.Update(oldDistributedCompany);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Updating");
            }
            output.Message = "Data Updated Sucessfully";
            return output;
        }
    }
}
