using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class CreatePurchasingBillHandler : IRequestHandler<CreatePurchasingBillHandlerInput, CreatePurchasingBillHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreatePurchasingBillHandler> _logger;
        public CreatePurchasingBillHandler(ILogger<CreatePurchasingBillHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreatePurchasingBillHandlerOutput> Handle(CreatePurchasingBillHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreatePurchasingBill business logic");
            CreatePurchasingBillHandlerOutput output = new CreatePurchasingBillHandlerOutput(request.CorrelationId());
            using TransactionDealerRepository transaction = new TransactionDealerRepository(_databaseService);
            var purchasingbill = new PurchasingBill();
            purchasingbill.totalPrice = request.totalPrice;
            purchasingbill.discount = request.discount;
            purchasingbill.tax=request.tax;
            purchasingbill.timeCreated = DateTime.Now;
            //هنجيب اليوزر من الريكوست????
            purchasingbill.userId = request.userId;
            purchasingbill.representerId = request.representerId;
            _databaseService.purchasingBills.Add(purchasingbill);
            _databaseService.DBSaveChanges();
            foreach (var item in request.purchasing_Details)
            {
                purchasingbill.PuchasingBillDetails.Add(
                   new PuchasingBillDetails
                   {
                       quantity = item.quantity,
                       itemId = item.itemId,
                       unitId = item.unitId,
                       purchasingbillId=purchasingbill.Id
                   }
                   );
            }
            _databaseService.DBSaveChanges();
            transaction.SetComplete();
            output.Message = "Data Saved Sucessfully";

            return output;
        }
    }
}
