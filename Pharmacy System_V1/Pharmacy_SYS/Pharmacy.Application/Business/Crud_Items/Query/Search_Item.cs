using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_Items.Query
{
    public class Search_ItemHandler : IRequestHandler<Search_ItemHandlerInput, Search_ItemHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Search_ItemHandler> _logger;
        public Search_ItemHandler(ILogger<Search_ItemHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Search_ItemHandlerOutput> Handle(Search_ItemHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Search_Item business logic");
            Search_ItemHandlerOutput output = new Search_ItemHandlerOutput(request.CorrelationId());

            var AllItems = await _databaseService.items.Select(o=>new SearchAllItems
            {
                Id = o.Id,
                tradeNameEn = o.tradeNameEn,
                tradeNameAr = o.tradeNameAr,
                chemicalName = o.chemicalName,
                Code = o.Code,
                molality = o.molality,
                duration = o.duration,
                buyingPrice = o.buyingPrice,
                sellingPrice = o.sellingPrice,
                itemtypeId = o.itemtypeId,
                manufactureId = o.manufactureId,
                distributedId = o.distributedId,
                clenderId = o.clenderId
            }).ToListAsync(cancellationToken);

            if(!String.IsNullOrEmpty(request.tradeNameEn))
                AllItems = AllItems.Where(o=> o.tradeNameEn.StartsWith(request.tradeNameEn.Trim())).ToList();
            if (!String.IsNullOrEmpty(request.tradeNameAr))
                AllItems = AllItems.Where(o => o.tradeNameAr.StartsWith(request.tradeNameAr.Trim())).ToList();
            if (!String.IsNullOrEmpty(request.chemicalName))
                AllItems = AllItems.Where(o => o.chemicalName.StartsWith(request.chemicalName.Trim())).ToList();
            if (!String.IsNullOrEmpty(request.Code))
                AllItems = AllItems.Where(o => o.Code.StartsWith(request.Code.Trim())).ToList();
            if (request.molality.HasValue)
                AllItems = AllItems.Where(o => o.molality == request.molality).ToList();
            if (request.duration.HasValue)
                AllItems = AllItems.Where(o => o.duration == request.duration).ToList();
            if (request.buyingPrice.HasValue)
                AllItems = AllItems.Where(o => o.buyingPrice == request.buyingPrice).ToList();
            if (request.sellingPrice.HasValue)
                AllItems = AllItems.Where(o => o.sellingPrice == request.sellingPrice).ToList();
            if (request.itemtypeId.HasValue)
                AllItems = AllItems.Where(o => o.itemtypeId == request.itemtypeId).ToList();
            if (request.manufactureId.HasValue)
                AllItems = AllItems.Where(o => o.manufactureId == request.manufactureId).ToList();
            if (request.distributedId.HasValue)
                AllItems = AllItems.Where(o => o.distributedId == request.distributedId).ToList();
            if (request.clenderId.HasValue)
                AllItems = AllItems.Where(o => o.clenderId == request.clenderId).ToList();

            output.SearchAllItem = AllItems;

            return output;
        }
    }
}
