using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_SellingBill.Command
{
    public class CreateSellingBillHandler : IRequestHandler<CreateSellingBillHandlerInput, CreateSellingBillHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreateSellingBillHandler> _logger;
        public CreateSellingBillHandler(ILogger<CreateSellingBillHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreateSellingBillHandlerOutput> Handle(CreateSellingBillHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateSellingBill business logic");
            CreateSellingBillHandlerOutput output = new CreateSellingBillHandlerOutput(request.CorrelationId());
            using TransactionDealerRepository transaction = new TransactionDealerRepository(_databaseService);
            var sellingBill = new SellingBill();
            sellingBill.totalPrice = request.totalPrice;
            sellingBill.discount = request.discount;
            sellingBill.tax = request.tax;
            sellingBill.timeCreated = DateTime.Now;
            //هنجيب اليوزر من الريكوست????
            sellingBill.userId = request.userId;
            _databaseService.sellingBills.Add(sellingBill);
            _databaseService.DBSaveChanges();
            foreach (var item in request.purchasing_Details)
            {
                sellingBill.SellingBillDetails.Add(
                   new SellingBillDetails
                   {
                       quantity = item.quantity,
                       itemId = item.itemId,
                       unitId = item.unitId,
                        sellingbillId= sellingBill.Id
                   }
                   );
            }
            //saved
            _databaseService.DBSaveChanges();
            transaction.SetComplete();
            output.Message = "Data Saved Sucessfully";
            return output;
        }
    }
}
