using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Query
{
    public class GetPurchasingBillByIdHandler : IRequestHandler<GetPurchasingBillByIdHandlerInput, GetPurchasingBillByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetPurchasingBillByIdHandler> _logger;
        public GetPurchasingBillByIdHandler(ILogger<GetPurchasingBillByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetPurchasingBillByIdHandlerOutput> Handle(GetPurchasingBillByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetPurchasingBillById business logic");
            GetPurchasingBillByIdHandlerOutput output = new GetPurchasingBillByIdHandlerOutput(request.CorrelationId());
            var PruchasingWithDetails = await _databaseService.purchasingBills.Include(o => o.PuchasingBillDetails).FirstOrDefaultAsync(cancellationToken);
            if (PruchasingWithDetails != null)
            output.Id=PruchasingWithDetails.Id;
            output.totalPrice = PruchasingWithDetails.totalPrice;
            output.discount = PruchasingWithDetails.discount;
            output.tax= PruchasingWithDetails.tax;
            output.userId = PruchasingWithDetails.userId;
            output.representerId= PruchasingWithDetails.representerId;
            output.purchasing_Details = PruchasingWithDetails.PuchasingBillDetails.Select(o => new PurDetails
            {
                id = o.Id,
                quantity = o.quantity,
                itemId = o.itemId,
                unitId = o.unitId,
                purchasingbillId = o.purchasingbillId,
            }).ToList();

            return output;
        }
    }
}
