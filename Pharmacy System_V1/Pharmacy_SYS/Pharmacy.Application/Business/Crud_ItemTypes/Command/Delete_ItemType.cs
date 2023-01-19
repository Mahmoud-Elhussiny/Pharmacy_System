using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Delete_ItemTypeHandler : IRequestHandler<Delete_ItemTypeHandlerInput, Delete_ItemTypeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Delete_ItemTypeHandler> _logger;
        public Delete_ItemTypeHandler(ILogger<Delete_ItemTypeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Delete_ItemTypeHandlerOutput> Handle(Delete_ItemTypeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Delete_ItemType business logic");
            Delete_ItemTypeHandlerOutput output = new Delete_ItemTypeHandlerOutput(request.CorrelationId());

            var itemtypeDeleted = await _databaseService.itemTypes
                .Where(o => o.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            
            if (itemtypeDeleted == null)
            {
                throw new WebApiException("this item type is not found");
            }

            _databaseService.itemTypes.Remove(itemtypeDeleted);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Can't Deleted data");
            }

            output.Message = "data Deleted Successfully";


            return output;
        }
    }
}
