using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class DeleteDistibutedCompanyHandler : IRequestHandler<DeleteDistibutedCompanyHandlerInput, DeleteDistibutedCompanyHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<DeleteDistibutedCompanyHandler> _logger;
        public DeleteDistibutedCompanyHandler(ILogger<DeleteDistibutedCompanyHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<DeleteDistibutedCompanyHandlerOutput> Handle(DeleteDistibutedCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling DeleteDistibutedCompany business logic");
            DeleteDistibutedCompanyHandlerOutput output = new DeleteDistibutedCompanyHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var oldDistributedCompany = await _databaseService.distributedCompanies.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (oldDistributedCompany == null)
            {
                throw new WebApiException("The Manufacturer Not Found");
            }
            _databaseService.distributedCompanies.Remove(oldDistributedCompany);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Delete The Distributed Company");
            }
            output.Message = "Data Deleted Sucessfully";
            return output;
        }
    }
}
