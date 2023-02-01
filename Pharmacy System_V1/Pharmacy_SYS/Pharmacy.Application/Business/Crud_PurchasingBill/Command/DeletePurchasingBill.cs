using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Command
{
    public class DeletePurchasingBillHandler : IRequestHandler<DeletePurchasingBillHandlerInput, DeletePurchasingBillHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<DeletePurchasingBillHandler> _logger;
        public DeletePurchasingBillHandler(ILogger<DeletePurchasingBillHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<DeletePurchasingBillHandlerOutput> Handle(DeletePurchasingBillHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling DeletePurchasingBill business logic");
            DeletePurchasingBillHandlerOutput output = new DeletePurchasingBillHandlerOutput(request.CorrelationId());
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
            var allpurchasingdetails = _databaseService.puchasingBillDetails.Where(o => o.Id == purchasingbill.Id).ToList();
            if(!allpurchasingdetails.Any())
            {
                throw new WebApiException("There Are No Items");
            }
            _databaseService.puchasingBillDetails.RemoveRange(allpurchasingdetails);
            _databaseService.DBSaveChanges();
            _databaseService.purchasingBills.Remove(purchasingbill);
            _databaseService.DBSaveChanges();
            transaction.SetComplete();
            output.Message = "Data Deleted Sucessfully";
            return output;
        }
    }
}
