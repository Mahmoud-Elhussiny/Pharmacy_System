using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_Items.Query
{
    public class GetAll_ItemsHandler : IRequestHandler<GetAll_ItemsHandlerInput, GetAll_ItemsHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAll_ItemsHandler> _logger;
        public GetAll_ItemsHandler(ILogger<GetAll_ItemsHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAll_ItemsHandlerOutput> Handle(GetAll_ItemsHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAll_Items business logic");
            GetAll_ItemsHandlerOutput output = new GetAll_ItemsHandlerOutput(request.CorrelationId());

            var allitem = await _databaseService.items.Select(o => new AllItems
            {
                Id = o.Id,
                tradeNameEn = o.tradeNameEn,
                tradeNameAr = o.tradeNameAr,
                chemicalName = o.chemicalName,
                Code = o.Code,
                batchNo = o.batchNo,
                molality = o.molality,
                duration = o.duration,
                buyingPrice = o.buyingPrice,
                sellingPrice = o.sellingPrice,
                itemtypeId = o.itemtypeId,
                manufactureId = o.manufactureId,
                distributedId = o.distributedId,
                clenderId = o.clenderId

            }).ToListAsync(cancellationToken);
            output._AllItems = allitem;
            return output;
        }
    }
}
