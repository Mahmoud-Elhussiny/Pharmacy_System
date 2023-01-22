using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class CreateTheManufacturerHandler : IRequestHandler<CreateTheManufacturerHandlerInput, CreateTheManufacturerHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreateTheManufacturerHandler> _logger;
        public CreateTheManufacturerHandler(ILogger<CreateTheManufacturerHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreateTheManufacturerHandlerOutput> Handle(CreateTheManufacturerHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateTheManufacturer business logic");
            CreateTheManufacturerHandlerOutput output = new CreateTheManufacturerHandlerOutput(request.CorrelationId());
            if (_databaseService.TheManufacturer.Any(o => o.NameAr == request.NameAr || o.NameEn.ToLower() == request.NameEn.ToLower()))
            {
                throw new WebApiException("The Manufacturer Name Already Exsit");
            }
            var theManfucturer = new TheManufacturer();
            theManfucturer.NameAr = request.NameAr.Trim();
            theManfucturer.NameEn = request.NameEn.Trim();
            theManfucturer.Location = request.Location;
            theManfucturer.Phone = request.Phone;
            await _databaseService.TheManufacturer.AddAsync(theManfucturer);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Saving");
            }
            output.Message = "Data Saved Sucessfully";

            return output;
        }
    }
}
