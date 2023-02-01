using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class UpdatePurchasigBillHandler : IRequestHandler<UpdatePurchasigBillHandlerInput, UpdatePurchasigBillHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<UpdatePurchasigBillHandler> _logger;
        public UpdatePurchasigBillHandler(ILogger<UpdatePurchasigBillHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<UpdatePurchasigBillHandlerOutput> Handle(UpdatePurchasigBillHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling UpdatePurchasigBill business logic");
            UpdatePurchasigBillHandlerOutput output = new UpdatePurchasigBillHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            using TransactionDealerRepository transaction = new TransactionDealerRepository(_databaseService);
            var purchasingbill = _databaseService.purchasingBills.FirstOrDefault(i => i.Id == request.Id);
            if (purchasingbill == null)
            {
                throw new WebApiException("Data Not Found");
            }
            if(request.totalPrice.HasValue)
            purchasingbill.totalPrice = (decimal)request.totalPrice;
            if (request.discount.HasValue)
                purchasingbill.discount = (int)request.discount;
            if (request.tax.HasValue)
                purchasingbill.tax = (int)request.tax;
            if (!string.IsNullOrEmpty(request.userId))
                purchasingbill.userId = request.userId;
            if (request.representerId.HasValue && !request.representerId.Equals(0))
                purchasingbill.representerId = request.representerId;
            _databaseService.purchasingBills.Update(purchasingbill);
            _databaseService.DBSaveChanges();
            var allpurchasingdetails=_databaseService.puchasingBillDetails.Where(o=>o.Id==purchasingbill.Id).ToList();
            if (allpurchasingdetails.Any())
            {
                foreach (var item in request.purchasing_Details)
                {
                    foreach (var details in allpurchasingdetails) {
                        if (item.quantity.HasValue)
                        {
                            details.quantity = (int)item.quantity;
                        }
                        if (item.itemId.HasValue)
                        {
                        details.itemId = (int)item.itemId;
                        }
                        if (item.unitId.HasValue)
                        {
                            details.unitId = (int)item.unitId;
                        }
                        if (item.purchasingbillId.HasValue)
                        {
                            details.purchasingbillId = (int)item.purchasingbillId;
                        }
                    }
                    _databaseService.puchasingBillDetails.UpdateRange(allpurchasingdetails);
                    _databaseService.DBSaveChanges();
                } 
            }
            output.Message = "Data Updated Sucessfully";
            return output;
        }
    }
}
