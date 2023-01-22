using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class CreateDistrbutedCompanyHandler : IRequestHandler<CreateDistrbutedCompanyHandlerInput, CreateDistrbutedCompanyHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreateDistrbutedCompanyHandler> _logger;
        public CreateDistrbutedCompanyHandler(ILogger<CreateDistrbutedCompanyHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreateDistrbutedCompanyHandlerOutput> Handle(CreateDistrbutedCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateDistrbutedCompany business logic");
            CreateDistrbutedCompanyHandlerOutput output = new CreateDistrbutedCompanyHandlerOutput(request.CorrelationId());
            if (_databaseService.distributedCompanies.Any(o => o.NameAr == request.NameAr || o.NameEn.ToLower() == request.NameEn.ToLower()))
            {
                throw new WebApiException("The Distributed Company Name Already Exsit");
            }
            var distibutedcompny = new DistributedCompany();
            distibutedcompny.NameAr = request.NameAr.Trim();
            distibutedcompny.NameEn = request.NameEn.Trim();
            distibutedcompny.Location = request.Location;
            distibutedcompny.Phone = request.Phone;
            if (request.TheManufacturerId.HasValue && request.TheManufacturerId.Value==0)
            {
                throw new WebApiException("Forign Key Cannot Be Less Than1");
            }
            distibutedcompny.TheManufacturerId=request.TheManufacturerId;
            await _databaseService.distributedCompanies.AddAsync(distibutedcompny);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Saving");
            }
            output.Message = "Data Saved Sucessfully";
            return output;
        }
    }
}
