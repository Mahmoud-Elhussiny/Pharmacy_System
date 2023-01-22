using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class DeleteTheManufacturerHandler : IRequestHandler<DeleteTheManufacturerHandlerInput, DeleteTheManufacturerHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<DeleteTheManufacturerHandler> _logger;
        public DeleteTheManufacturerHandler(ILogger<DeleteTheManufacturerHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<DeleteTheManufacturerHandlerOutput> Handle(DeleteTheManufacturerHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling DeleteTheManufacturer business logic");
            DeleteTheManufacturerHandlerOutput output = new DeleteTheManufacturerHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var Manufacturer = await _databaseService.TheManufacturer.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (Manufacturer == null)
            {
                throw new WebApiException("The Manufacturer Not Found");
            }
            _databaseService.TheManufacturer.Remove(Manufacturer);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Delete The Manufacturer");
            }
            output.Message = "Data Deleted Sucessfully";
            return output;
        }
    }
}
