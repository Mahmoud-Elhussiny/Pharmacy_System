using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Query
{
    public class GetAllPurchasingBillHandler : IRequestHandler<GetAllPurchasingBillHandlerInput, GetAllPurchasingBillHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAllPurchasingBillHandler> _logger;
        public GetAllPurchasingBillHandler(ILogger<GetAllPurchasingBillHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAllPurchasingBillHandlerOutput> Handle(GetAllPurchasingBillHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAllPurchasingBill business logic");
            GetAllPurchasingBillHandlerOutput output = new GetAllPurchasingBillHandlerOutput(request.CorrelationId());
            var AllPruchasingWithDetails = await _databaseService.purchasingBills.Include(o => o.PuchasingBillDetails).ToListAsync(cancellationToken);
            output.pruchasing_Bills = AllPruchasingWithDetails.Select(o => new Pruchasing_Bill
            {
                Id = o.Id,
                totalPrice = o.totalPrice,
                tax = o.tax,
                discount = o.discount,
                userId = o.userId,
                representerId = o.representerId,
                purchasing_Details = o.PuchasingBillDetails.Select(o => new purchasingDetils
                {
                    id = o.Id,
                    quantity = o.quantity,
                    itemId = o.itemId,
                    unitId = o.unitId,
                    purchasingbillId = o.purchasingbillId,
                }).ToList()
            }).ToList();
            return output;
        }
    }
}
