using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_PurchasingBill.Query
{
    public class SearchForPurchasingBillHandler : IRequestHandler<SearchForPurchasingBillHandlerInput, SearchForPurchasingBillHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<SearchForPurchasingBillHandler> _logger;
        public SearchForPurchasingBillHandler(ILogger<SearchForPurchasingBillHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<SearchForPurchasingBillHandlerOutput> Handle(SearchForPurchasingBillHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling SearchForPurchasingBill business logic");
            SearchForPurchasingBillHandlerOutput output = new SearchForPurchasingBillHandlerOutput(request.CorrelationId());
            await Task.CompletedTask;
            return output;
        }
    }
}
