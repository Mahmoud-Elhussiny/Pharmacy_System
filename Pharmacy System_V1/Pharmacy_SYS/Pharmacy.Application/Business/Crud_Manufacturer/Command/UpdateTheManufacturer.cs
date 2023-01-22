using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class UpdateTheManufacturerHandler : IRequestHandler<UpdateTheManufacturerHandlerInput, UpdateTheManufacturerHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<UpdateTheManufacturerHandler> _logger;
        public UpdateTheManufacturerHandler(ILogger<UpdateTheManufacturerHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<UpdateTheManufacturerHandlerOutput> Handle(UpdateTheManufacturerHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling UpdateTheManufacturer business logic");
            UpdateTheManufacturerHandlerOutput output = new UpdateTheManufacturerHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var oldManufacturer= await _databaseService.TheManufacturer.Where(i=>i.Id==request.Id).FirstOrDefaultAsync(cancellationToken);
            if (oldManufacturer == null)
            {
                throw new WebApiException("The Manufacturer Not Found");
            }
            if(!string.IsNullOrEmpty(request.NameAr))
                oldManufacturer.NameAr = request.NameAr.Trim();
            if(!string.IsNullOrEmpty(request.NameEn))
                oldManufacturer.NameEn = request.NameEn.Trim();
            if(!string.IsNullOrEmpty(request.Location))
                oldManufacturer.Location = request.Location;
            if(!string.IsNullOrEmpty(request.Phone))
                oldManufacturer.Phone = request.Phone;
             _databaseService.TheManufacturer.Update(oldManufacturer);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Updating");
            }
            output.Message = "Data Updated Sucessfully";
            return output;
        }
    }
}
