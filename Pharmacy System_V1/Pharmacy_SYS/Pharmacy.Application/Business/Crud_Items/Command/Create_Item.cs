using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Create_ItemHandler : IRequestHandler<Create_ItemHandlerInput, Create_ItemHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Create_ItemHandler> _logger;
        public Create_ItemHandler(ILogger<Create_ItemHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Create_ItemHandlerOutput> Handle(Create_ItemHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Create_Item business logic");
            Create_ItemHandlerOutput output = new Create_ItemHandlerOutput(request.CorrelationId());

            var newItem = new Item();

            newItem.tradeNameEn = request.tradeNameEn.Trim();
            newItem.tradeNameAr = request.tradeNameAr.Trim();
            newItem.chemicalName = request.chemicalName.Trim();
            newItem.Code = request.Code.Trim();
            newItem.molality = request.molality;
            newItem.duration = request.duration;
            newItem.buyingPrice = request.buyingPrice;
            newItem.sellingPrice = request.sellingPrice;
            newItem.itemtypeId = request.itemtypeId;
            newItem.manufactureId = request.manufactureId;
            newItem.distributedId = request.distributedId;
            newItem.clenderId = request.clenderId;
            
            _databaseService.items.Add(newItem);

            if(await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error In Saving Data");
            }

            output.Message = "Data Created Successfully";

            return output;
        }
    }
}
