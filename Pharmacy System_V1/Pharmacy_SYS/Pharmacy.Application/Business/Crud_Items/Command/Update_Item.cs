using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Update_ItemHandler : IRequestHandler<Update_ItemHandlerInput, Update_ItemHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Update_ItemHandler> _logger;
        public Update_ItemHandler(ILogger<Update_ItemHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Update_ItemHandlerOutput> Handle(Update_ItemHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Update_Item business logic");
            Update_ItemHandlerOutput output = new Update_ItemHandlerOutput(request.CorrelationId());

            var itemUpdated = await _databaseService.items.Where(o => o.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            if (itemUpdated == null)
                throw new WebApiException("this Item Is Not Found");

            if (!String.IsNullOrEmpty(request.tradeNameEn))
                itemUpdated.tradeNameEn = request.tradeNameEn.Trim();

            if(!String.IsNullOrEmpty(request.tradeNameAr))
                itemUpdated.tradeNameAr = request.tradeNameAr.Trim();
            if(!String.IsNullOrEmpty(request.chemicalName))
                itemUpdated.chemicalName = request.chemicalName.Trim();
            if(!String.IsNullOrEmpty(request.Code))
                itemUpdated.Code = request.Code.Trim();
            if(request.molality.HasValue)
                itemUpdated.molality = request.molality;
            if (request.duration.HasValue)
                itemUpdated.duration = request.duration.Value;
            if (request.buyingPrice.HasValue)
                itemUpdated.buyingPrice = request.buyingPrice;
            if (request.sellingPrice.HasValue)
                itemUpdated.sellingPrice = request.sellingPrice;
            if(request.itemtypeId.HasValue)
                itemUpdated.itemtypeId = request.itemtypeId;
            if (request.manufactureId.HasValue)
                itemUpdated.manufactureId = request.manufactureId;
            //if(request.distributedId.HasValue)
            //    itemUpdated.distributedId = request.distributedId;
            if(request.clenderId.HasValue)
                itemUpdated.clenderId = request.clenderId; 

            _databaseService.items.Update(itemUpdated);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new WebApiException("Error In Updated Data");

            output.Message = "Data Updated Successfully";




            await Task.CompletedTask;
            return output;
        }
    }
}
