using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Update_ItemTypeHandler : IRequestHandler<Update_ItemTypeHandlerInput, Update_ItemTypeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Update_ItemTypeHandler> _logger;
        public Update_ItemTypeHandler(ILogger<Update_ItemTypeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Update_ItemTypeHandlerOutput> Handle(Update_ItemTypeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Update_ItemType business logic");
            Update_ItemTypeHandlerOutput output = new Update_ItemTypeHandlerOutput(request.CorrelationId());

            var itemtypeUpdated = await _databaseService.itemTypes
                .Where(o => o.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (itemtypeUpdated == null)
            {
                throw new WebApiException("this item type is not found");
            }

            if (!String.IsNullOrEmpty(request.nameEn))
                itemtypeUpdated.nameEn = request.nameEn.Trim();
            if (!String.IsNullOrEmpty(request.nameAr))
                itemtypeUpdated.nameAr = request.nameAr.Trim();

            _databaseService.itemTypes.Update(itemtypeUpdated);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Can't Updated data");
            }

            output.Message = "data Updated Successfully";

            return output;
        }
    }
}
