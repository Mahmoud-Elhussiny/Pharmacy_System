using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Delete_ItemHandler : IRequestHandler<Delete_ItemHandlerInput, Delete_ItemHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Delete_ItemHandler> _logger;
        public Delete_ItemHandler(ILogger<Delete_ItemHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Delete_ItemHandlerOutput> Handle(Delete_ItemHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Delete_Item business logic");
            Delete_ItemHandlerOutput output = new Delete_ItemHandlerOutput(request.CorrelationId());

            var itemDeleted = await _databaseService.items.Where(o => o.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            if (itemDeleted == null)
                throw new WebApiException("this Item Is Not Found");

            _databaseService.items.Remove(itemDeleted);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new WebApiException("Error In Deleting Data");

            output.Message = "Data Deleted Successfully";


            return output;
        }
    }
}
